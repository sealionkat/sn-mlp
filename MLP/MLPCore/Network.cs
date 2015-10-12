using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;

namespace MLPCore
{
    public abstract class Network
    {
        private string trainingFile;
        private string testFile;
        private BasicNetwork network;
        private int iterations;

        protected abstract int FirstLayerNeuronCount { get; }
        protected abstract int LastLayerNeuronCount { get; }

        public enum ActivationFunctionType
        {
            UniPolar,
            BiPolar
        }

        private IActivationFunction CreateActivationFunction(ActivationFunctionType fType)
        {
            switch(fType)
            {
                case ActivationFunctionType.BiPolar:
                    return new ActivationBiPolar();
                case ActivationFunctionType.UniPolar:
                    return new ActivationStep();
                default:
                    return null;
            }
        }

        private void CreateNetwork(List<int> structure, ActivationFunctionType fType, bool bias)
        {
            network = new BasicNetwork();

            // Pierwsza warstwa nie ma funkcji aktywacji.
            network.AddLayer(new BasicLayer(null, bias, FirstLayerNeuronCount));

            foreach(int neurons in structure)
            {
                network.AddLayer(new BasicLayer(CreateActivationFunction(fType), bias, neurons));
            }

            // Ostatnia warstwa nie ma biasu.
            network.AddLayer(new BasicLayer(CreateActivationFunction(fType), false, LastLayerNeuronCount));

            network.Structure.FinalizeStructure();
            network.Reset();
        }

        public Network(string trainingSetFile, string testSetFile, int iterationCount, List<int> networkStructure, 
            ActivationFunctionType activationFunctionType, bool bias)
        {
            trainingFile = trainingSetFile;
            testFile = testSetFile;
            iterations = iterationCount;

            CreateNetwork(networkStructure, activationFunctionType, bias);
            // TODO: Load Sets
        }

        public abstract void Run();
    }
}
