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
    public class ClassificationNetwork : Network
    {
        protected override int FirstLayerNeuronCount
        {
            get { return 2; }
        }

        protected override int LastLayerNeuronCount
        {
            get { return uniqueClassess; }
        }

        public ClassificationNetwork(string trainingSetFile, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias) :
            base(trainingSetFile, networkStructure, activationFunctionType, bias)
        {
        }

        protected override void LoadTrainData(string trainingFile)
        {
            ReadCSV train_csv = new ReadCSV(trainingFile, true, CSVFormat.DecimalPoint);

            List<double[]> train_input = new List<double[]>();
            List<int> train_ideal_class = new List<int>();
            train_input_orig = new List<Results>();

            while (train_csv.Next())
            {
                double x = train_csv.GetDouble(0);
                double y = train_csv.GetDouble(1);
                int r = (int)train_csv.GetDouble(2);

                train_input.Add(new[] { x, y });
                train_ideal_class.Add(r);
                train_input_orig.Add(new Results(x, y, r));
            }

            train_csv.Close();

            List<double[]> train_ideal = MakeIdealFromInput(train_ideal_class);

            Analyze(ref train_input, ref vmin, ref vmax);
            Normalize(ref train_input, ref vmin, ref vmax);

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
                double y = test_csv.GetDouble(1);

                test_input.Add(new[] { x, y });
                test_input_orig.Add(new[] { x, y });
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

        public override Tuple<List<Results>, List<Results>> Test(string testSetFile)
        {
            LoadTestData(testSetFile);

            List<Results> res = new List<Results>();

            int j = 0;
            foreach (var dd in testData)
            {
                var d = network.Compute(dd);
                int cls = 1;

                for (int i = 1; i < LastLayerNeuronCount; ++i)
                {
                    if (d[i] > d[i - 1])
                        ++cls;
                }

                res.Add(new Results(test_input_orig[j][0], test_input_orig[j][1], cls));
                ++j;
            }

            return new Tuple<List<Results>, List<Results>>(res, train_input_orig);
        }
    }
}
