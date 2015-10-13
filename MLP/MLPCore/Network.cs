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
                    return new ActivationBiPolar();
                case ActivationFunctionType.UniPolar:
                    return new ActivationStep();
                default:
                    return null;
            }
        }

        private List<double[]> MakeIdealFromInput(List<int> input)
        {
            List<double[]> train_ideal = new List<double[]>();

            HashSet<int> unique = new HashSet<int>(input);
            int[] unique_idx = unique.ToArray();

            foreach (int v in input)
            {
                double[] ideal_item = new double[unique_idx.Length];
                for (int i = 0; i < unique_idx.Length; ++i)
                {
                    // TODO: od 0 czy -1?
                    ideal_item[i] = unique_idx[i] == v ? 1.0 : -1.0;
                }

                train_ideal.Add(ideal_item);
            }

            return train_ideal;
        }

        private void Normalize(ref List<double[]> data)
        {
            double[] vmin = new double[data[0].Length];
            double[] vmax = new double[data[0].Length];

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

            // TODO: od 0?
            double min_value = -1.0;
            double max_value = 1.0;
            double norm_size = max_value - min_value;

            foreach (double[] item in data)
            {
                for (int i = 0; i < item.Length; ++i)
                {
                    double d_size = vmax[i] - vmin[i];
                    item[i] = ((item[i] - vmin[i]) * norm_size / d_size) + min_value;
                }
            }
        }

        private void LoadData(string trainingFile, string testFile)
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

            List<double[]> train_ideal = MakeIdealFromInput(train_ideal_class);
            Normalize(ref train_input);

            trainingData = new BasicMLDataSet(train_input.ToArray(), train_ideal.ToArray());

            /*IVersatileDataSource trainSource = new CSVDataSource(trainingFile, true, CSVFormat.DecimalPoint);
            var tData = new VersatileMLDataSet(trainSource);

            tData.DefineSourceColumn("x", ColumnType.Continuous);
            tData.DefineSourceColumn("y", ColumnType.Continuous);
            var o = tData.DefineSourceColumn("cls", ColumnType.Nominal);

            tData.Analyze();

            tData.DefineSingleOutputOthersInput(o);

            var model = new EncogModel(tData);
            model.SelectMethod(tData, MLMethodFactory.TypeFeedforward);
            //tData.NormHelper.NormStrategy = new BasicNormalizationStrategy(0, 1, 0, 1);

            tData.Normalize();

            Console.WriteLine(tData.CalculatedIdealSize);

            trainingData = tData;*/
        }

        private void CreateNetwork(List<int> structure, ActivationFunctionType fType, bool bias)
        {
            network = new BasicNetwork();

            // Pierwsza warstwa nie ma funkcji aktywacji.
            network.AddLayer(new BasicLayer(null, bias, FirstLayerNeuronCount));

            foreach (int neurons in structure)
            {
                network.AddLayer(new BasicLayer(CreateActivationFunction(fType), bias, neurons));
            }

            // Ostatnia warstwa nie ma biasu.
            network.AddLayer(new BasicLayer(CreateActivationFunction(fType), false, LastLayerNeuronCount));

            network.Structure.FinalizeStructure();
            network.Reset();
        }

        public Network(string trainingSetFile, string testSetFile, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias)
        {
            LoadData(trainingSetFile, testSetFile);
            CreateNetwork(networkStructure, activationFunctionType, bias);
        }

        public virtual List<double> Train(int iterationCount, double learnRate, double momentum)
        {
            List<double> error = new List<double>();

            var training = new Backpropagation(network, trainingData/*, learnRate, momentum*/);

            //for (int i = 0; i < iterationCount; ++i)
            int i = 0;
            while(true)
            {
                training.Iteration(1);
                if (training.Error <= 0.1)
                    break;
                //error.Add(training.Error);
                //Console.WriteLine(training.Error);
                // TODO: powiadomienia przez delegate?
                ++i;
                if(i%1000 == 0)
                    Console.WriteLine(training.Error);
            }

            training.FinishTraining();

            return error;
        }

        public void Test() { }
    }
}
