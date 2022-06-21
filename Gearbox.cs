using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormWorks_Gearbox_Calculator
{
    public class Gearbox
    {
        public double ratioOn { get; private set; }
        public double ratioOff { get; private set; }
        public string ratioStringOn { get; private set; }
        public string ratioStringOff { get; private set; }
        public double loss { get; private set; }

        public Gearbox(string ratioOn, string ratioOff = "1/1", double loss = 0.05)
        {
            this.ratioOn = (int.Parse(ratioOn.Substring(0, ratioOn.IndexOf('/')))/int.Parse(ratioOn.Substring(ratioOn.IndexOf('/') + 1)));
            this.ratioOff = (int.Parse(ratioOff.Substring(0, ratioOff.IndexOf('/'))) / int.Parse(ratioOff.Substring(ratioOff.IndexOf('/') + 1)));
            this.loss = loss;
            this.ratioStringOn = ratioOn;
            this.ratioStringOff = ratioOff;
        }
    }
}
