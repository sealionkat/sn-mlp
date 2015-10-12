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
            get { throw new NotImplementedException(); }
        }

        protected override int LastLayerNeuronCount
        {
            get { throw new NotImplementedException(); }
        }

        public override void Run(double learnRate, double momentum)
        {
            throw new NotImplementedException();
        }

        public RegressionNetwork(string trainingSetFile, string testSetFile, int iterationCount, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias) :
            base(trainingSetFile, testSetFile, iterationCount, networkStructure, activationFunctionType, bias)
        {

        }
    }
}
