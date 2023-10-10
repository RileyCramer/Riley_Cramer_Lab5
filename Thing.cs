using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject
{
    public class Thing
    {
        public string index { get; set; }
        public string name { get; set; }
        //public string URL { get; set; }

        public Thing() { }

        public Thing(string Index, string Name, string uRL)
        {
            this.index = index;
            this.name = Name;
            //URL = uRL;
        }

        public override string ToString()
        {
           string Thingtring = string.Empty;
            Thingtring += $"{this.index}\n";
            Thingtring += $"{this.name}\n";
            //Thingtring += $"{URL}\n";

            return Thingtring;
             
        }
    }
}
