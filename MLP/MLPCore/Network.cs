using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;
using Encog.Neural.Networks.Training.Propagation.Back;
using Encog.ML.Data;
using Encog.ML.Data.Versatile;
using Encog.ML.Data.Versatile.Sources;
using Encog.Util.CSV;
using Encog.ML.Data.Versatile.Columns;
using Encog.ML.Model;
using Encog.ML.Factory;
using Encog.ML.Data.Versatile.Normalizers.Strategy;
using Encog.ML.Data.Basic;

namespace MLPCore
{
    public abstract class Network
    {
        private BasicNetwork network;
        private IMLDataSet trainingData;
        private IMLDataSet validationData;
        private List<IMLData> testData;

        protected abstract int FirstLayerNeuronCount { get; }
        protected abstract int LastLayerNeuronCount { get; }

        public enum ActivationFunctionType
        {
            UniPolar,
            BiPolar
        }

        private IActivationFunction CreateActivationFunction(ActivationFunctionType fType)
        {
            switch (fType)
            {
                case ActivationFunctionType.BiPolar:
                    return new ActivationBipolarSteepenedSigmoid();
                case ActivationFunctionType.UniPolar:
                    return new ActivationSigmoid();
                default:
                    return null;
            }
        }

        private List<double[]> MakeIdealFromInput(List<int> input, ActivationFunctionType fType)
        {
            List<double[]> train_ideal = new List<double[]>();
            double min_val = (fType == ActivationFunctionType.BiPolar) ? -1.0 : 0.0;

            HashSet<int> unique = new HashSet<int>(input);
            int[] unique_idx = unique.ToArray();

            foreach (int v in input)
            {
                double[] ideal_item = new double[unique_idx.Length];
                for (int i = 0; i < unique_idx.Length; ++i)
                {
                    ideal_item[i] = unique_idx[i] == v ? 1.0 : min_val;
                }

                train_ideal.Add(ideal_item);
            }

            return train_ideal;
        }

        private void Analyze(ref List<double[]> data, out double[] vmin, out double[] vmax)
        {
            vmin = new double[data[0].Length];
            vmax = new double[data[0].Length];

            for (int i = 0; i < data[0].Length; ++i)
            {
                vmin[i] = double.PositiveInfinity;
                vmax[i] = double.NegativeInfinity;
            }

            foreach (double[] item in data)
            {
                for (int i = 0; i < item.Length; ++i)
                {
                    if (item[i] < vmin[i])
                        vmin[i] = item[i];

                    if (item[i] > vmax[i])
                        vmax[i] = item[i];
                }
            }
        }

        private void Normalize(ref List<double[]> data, ActivationFunctionType fType, ref double[] vmin, ref double[] vmax)
        {
            double min_value = (fType == ActivationFunctionType.BiPolar) ? -1.0 : 0.0;
            double max_value = 1.0;
            double norm_size = max_value - min_value;

            for (int i = 0; i < data[0].Length; ++i)
            {
                double d_size = vmax[i] - vmin[i];

                foreach (double[] item in data)
                {
                    item[i] = ((item[i] - vmin[i]) * norm_size / d_size) + min_value;
                }
            }
        }

        private void Randomize(ref List<double[]> input, ref List<double[]> ideal)
        {
            Random r = new Random();

            List<double[]> new_input = new List<double[]>();
            List<double[]> new_ideal = new List<double[]>();

            while(input.Count > 0)
            {
                int n = r.Next(input.Count);

                new_ideal.Add(ideal[n]);
                ideal.RemoveAt(n);

                new_input.Add(input[n]);
                input.RemoveAt(n);
            }

            input = new_input;
            ideal = new_ideal;
        }

        private void LoadData(string trainingFile, string testFile, ActivationFunctionType fType)
        {
            ReadCSV train_csv = new ReadCSV(trainingFile, true, CSVFormat.DecimalPoint);

            List<double[]> train_input = new List<double[]>();
            List<int> train_ideal_class = new List<int>();

            while (train_csv.Next())
            {
                double x = train_csv.GetDouble(0);
                double y = train_csv.GetDouble(1);
                int r = (int)train_csv.GetDouble(2);

                train_input.Add(new[] { x, y });
                train_ideal_class.Add(r);
            }

            train_csv.Close();

            List<double[]> train_ideal = MakeIdealFromInput(train_ideal_class, fType);

            double[] vmax, vmin;
            Analyze(ref train_input, out vmin, out vmax);
            Normalize(ref train_input, fType, ref vmin, ref vmax);
            Randomize(ref train_input, ref train_ideal);

            int validation_size = train_input.Count / 10;

            validationData = new BasicMLDataSet(train_input.Take(validation_size).ToArray(), train_ideal.Take(validation_size).ToArray());
            trainingData = new BasicMLDataSet(train_input.Skip(validation_size).ToArray(), train_ideal.Skip(validation_size).ToArray());

            ReadCSV test_csv = new ReadCSV(testFile, true, CSVFormat.DecimalPoint);

            List<double[]> test_input = new List<double[]>();

            while(test_csv.Next())
            {
                double x = test_csv.GetDouble(0);
                double y = test_csv.GetDouble(1);

                test_input.Add(new[] { x, y });
            }

            test_csv.Close();

            //Analyze(ref test_input, out vmin, out vmax);
            Normalize(ref test_input, fType, ref vmin, ref vmax);

            testData = new List<IMLData>();
            foreach(var d in test_input)
            {
                testData.Add(new BasicMLData(d));
            }
        }

        private void CreateNetwork(List<int> structure, ActivationFunctionType fType, bool bias)
        {
            network = new BasicNetwork();

            // Pierwsza warstwa nie ma funkcji aktywacji.
            //network.AddLayer(new BasicLayer(null, bias, FirstLayerNeuronCount));
            network.AddLayer(new BasicLayer(FirstLayerNeuronCount));

            foreach (int neurons in structure)
            {
                network.AddLayer(new BasicLayer(CreateActivationFunction(fType), bias, neurons));
            }

            // Ostatnia warstwa nie ma biasu.
            //network.AddLayer(new BasicLayer(CreateActivationFunction(fType), false, LastLayerNeuronCount));
            network.AddLayer(new BasicLayer(LastLayerNeuronCount));

            network.Structure.FinalizeStructure();
            network.Reset();
        }

        public Network(string trainingSetFile, string testSetFile, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias)
        {
            LoadData(trainingSetFile, testSetFile, activationFunctionType);
            CreateNetwork(networkStructure, activationFunctionType, bias);
        }

        public virtual List<Tuple<int, double, double>> Train(int iterationCount, double learnRate, double momentum)
        {
            List<Tuple<int, double, double>> error = new List<Tuple<int, double, double>>();

            var training = new Backpropagation(network, trainingData, learnRate, momentum);
            training.BatchSize = 1;

            for (int i = 0; i < iterationCount; ++i)
            {
                training.Iteration(1);
                network.CalculateError(validationData);
                double val_error = network.CalculateError(validationData);
                error.Add(new Tuple<int, double, double>(i, training.Error, val_error));
                //if(i%100 == 0)
                    //Console.WriteLine("{0}: [{1}; {2}]", i, training.Error, val_error);
            }

            training.FinishTraining();
            return error;
        }

        public List<Tuple<double, double, int>> Test() 
        {
            List<Tuple<double, double, int>> cvals = new List<Tuple<double, double, int>>();

            foreach(var dd in testData)
            {
                var d = network.Compute(dd);
                int cls = 1;

                for (int i = 1; i < LastLayerNeuronCount; ++i)
                {
                    if (d[i] > d[i - 1])
                        ++cls;
                }

                cvals.Add(new Tuple<double, double, int>(dd[0], dd[1], cls));
                //Console.WriteLine("[{0} {1}]: {2}", dd[0], dd[1], cls);
            }

            return cvals;
        }
    }
}
