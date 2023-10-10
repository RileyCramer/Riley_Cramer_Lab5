using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ApiProject
{
    //Speels acts as the base that puls all of the information
    public class Spells : Thing
    {
        public List<Thing> Results { get; set; }

        public Spells()
        {

        }
            
        public Spells(List<Thing> results)
        {
            Results = results;
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

//Spells pulls the result specifically so that they cna all get pulled from it 