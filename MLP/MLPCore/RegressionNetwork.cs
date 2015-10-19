using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.Util.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPCore
{
    public class RegressionNetwork : Network
    {
        protected override int FirstLayerNeuronCount
        {
            get { return 1; }
        }

        protected override int LastLayerNeuronCount
        {
            get { return 1; }
        }

        public RegressionNetwork(string trainingSetFile, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias) :
            base(trainingSetFile, networkStructure, activationFunctionType, bias)
        {

        }

        protected override void LoadTrainData(string trainingFile)
        {
            ReadCSV train_csv = new ReadCSV(trainingFile, true, CSVFormat.DecimalPoint);

            List<double[]> train_input = new List<double[]>();
            List<double[]> train_ideal = new List<double[]>();

            train_input_orig = new List<Results>();

            while (train_csv.Next())
            {
                double x = train_csv.GetDouble(0);
                double y = train_csv.GetDouble(1);

                train_input.Add(new double[] { x });
                train_ideal.Add(new double[] { y });
                train_input_orig.Add(new Results(x, y, 0));
            }

            train_csv.Close();

            Analyze(ref train_input, ref vmin, ref vmax);
            Normalize(ref train_input, ref vmin, ref vmax);

            Analyze(ref train_ideal, ref vmino, ref vmaxo);
            Normalize(ref train_ideal, ref vmino, ref vmaxo);

            Randomize(ref train_input, ref train_ideal);

            int validation_size = train_input.Count / 10;

            validationData = new BasicMLDataSet(train_input.Take(validation_size).ToArray(), train_ideal.Take(validation_size).ToArray());
            trainingData = new BasicMLDataSet(train_input.Skip(validation_size).ToArray(), train_ideal.Skip(validation_size).ToArray());
        }

        protected override void LoadTestData(string testFile)
        {
            ReadCSV test_csv = new ReadCSV(testFile, true, CSVFormat.DecimalPoint);

            List<double[]> test_input = new List<double[]>();
            test_input_orig = new List<double[]>();

            while (test_csv.Next())
            {
                double x = test_csv.GetDouble(0);

                test_input.Add(new[] { x });
                test_input_orig.Add(new[] { x });
            }

            test_csv.Close();

            //Analyze(ref test_input);
            Normalize(ref test_input, ref vmin, ref vmax);

            testData = new List<IMLData>();
            foreach (var d in test_input)
            {
                testData.Add(new BasicMLData(d));
            }
        }

        private Results Denormalize(double x, double y)
        {
            double min_value = (fType == ActivationFunctionType.BiPolar) ? -1.0 : 0.0;
            double max_value = 1.0;
            double norm_size = max_value - min_value;

            double dx_size = vmax[0] - vmin[0];
            double dy_size = vmaxo[0] - vmino[0];

            x = ((x - min_value) * dx_size / norm_size) + vmin[0];
            y = ((y - min_value) * dy_size / norm_size) + vmino[0];

            return new Results(x, y, 0);
        }

        public override Tuple<List<Results>, List<Results>> Test(string testSetFile)
        {
            LoadTestData(testSetFile);

            List<Results> res = new List<Results>();

            foreach (var dd in testData)
            {
                var d = network.Compute(dd);

                res.Add(Denormalize(dd[0], d[0]));
                //Console.WriteLine("[{0}: {1}]", dd[0], d[0]);
            }

            return new Tuple<List<Results>, List<Results>>(res, train_input_orig);
        }
    }
}
