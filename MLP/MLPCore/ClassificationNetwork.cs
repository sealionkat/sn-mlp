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
            // TODO: Number of classes
            get { throw new NotImplementedException(); }
        }

        public override void Run(double learnRate, double momentum)
        {
            throw new NotImplementedException();
        }

        public ClassificationNetwork(string trainingSetFile, string testSetFile, int iterationCount, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias) :
            base(trainingSetFile, testSetFile, iterationCount, networkStructure, activationFunctionType, bias)
        {
        }
    }
}
