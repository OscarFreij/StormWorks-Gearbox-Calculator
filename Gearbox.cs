using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormWorks_Gearbox_Calculator
{
    public class Gearbox
    {
        public double ratio { get; private set; }
        public string ratioString { get; private set; }
        public double loss { get; private set; }

        public Gearbox(string ratio, double loss = 0.05)
        {
            this.ratio = (int.Parse(ratio.Substring(0 + ratio.IndexOf('/')))/int.Parse(ratio.Substring(ratio.IndexOf('/') + 1)));
            this.loss = loss;
            this.ratioString = ratio;
        }
    }
}
