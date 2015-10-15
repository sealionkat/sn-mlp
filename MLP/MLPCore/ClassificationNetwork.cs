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
            get { return 3; }
        }

        public override List<Tuple<int, double, double>> Train(int iterationCount, double learnRate, double momentum)
        {
            return base.Train(iterationCount, learnRate, momentum);
        }

        public ClassificationNetwork(string trainingSetFile, string testSetFile, List<int> networkStructure,
            ActivationFunctionType activationFunctionType, bool bias) :
            base(trainingSetFile, testSetFile, networkStructure, activationFunctionType, bias)
        {
        }
    }
}
