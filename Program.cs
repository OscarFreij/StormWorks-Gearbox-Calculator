using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormWorks_Gearbox_Calculator
{
    internal class Program
    {
        static List<Gearbox> gearboxes = new List<Gearbox>();
        static bool[,] cases = { { true, false, false }, { false, false, false }, { false, true, false }, { false, true, true } };
        static double baseRPS = 15.0;
        static double baseTourqe = 150;
        static void Main(string[] args)
        {
            gearboxes.Add(new Gearbox("-1/1"));
            gearboxes.Add(new Gearbox("2/1"));
            gearboxes.Add(new Gearbox("2/1"));

            for (int i = 0; i < cases.GetLength(0); i++)
            {
                double finalRatio = 1;
                double finalLoss = 1;

                for (int j = 0; j < gearboxes.Count(); j++)
                {
                    if (cases[i, j])
                    {
                        finalRatio = finalRatio * gearboxes[j].ratioOn;
                    }
                    else
                    {
                        finalRatio = finalRatio * gearboxes[j].ratioOff;
                    }
                    finalLoss = finalLoss * (1 - gearboxes[j].loss);
                }

                Console.WriteLine($"Case {i}:[ Ratio: {finalRatio} | Loss: {(1 - finalLoss)*100}% | Torque: {finalRatio * baseTourqe}N | RPS: {baseRPS / finalRatio}]");
            }

            Console.ReadLine();
        }
    }
}
