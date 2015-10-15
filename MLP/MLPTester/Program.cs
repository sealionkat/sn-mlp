using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLPCore;

namespace MLPTester
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Network n = new ClassificationNetwork("..\\..\\..\\..\\data\\data.train.csv", "..\\..\\..\\..\\data\\data.test.csv", 
                new List<int>() { 8 }, Network.ActivationFunctionType.BiPolar, true);

            n.Train(10000, 0.01, 0.1);
            n.Test();*/

            Network n = new RegressionNetwork("..\\..\\..\\..\\data\\data.xsq.train.csv", "..\\..\\..\\..\\data\\data.xsq.test.csv", 
                new List<int>() { 10,10 }, Network.ActivationFunctionType.UniPolar, true);

            n.Train(100000, 0.01, 0.1);
            n.Test();
        }
    }
}
