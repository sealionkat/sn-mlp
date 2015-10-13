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

        public override List<double> Train(int iterationCount, double learnRate, double momentum)
        {
            base.Train(iterationCount, learnRate, momentum);

            throw new NotImplementedException();
        }

        public RegressionNetwork(string trainingSetFile, string testSetFile, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias) :
            base(trainingSetFile, testSetFile, networkStructure, activationFunctionType, bias)
        {

        }
    }
}
