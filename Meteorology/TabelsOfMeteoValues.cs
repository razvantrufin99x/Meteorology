using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorology
{
    public class TabelsOfMeteoValues
    {
        public DateTime CurrentDateTime { get; set; }
        public List <MeteoDatasRecord> TheTableOfMeteoValues = new List<MeteoDatasRecord> ();
        public List <string > MeteoPrevisions = new List<string> ();

        public TabelsOfMeteoValues() { }
        public TabelsOfMeteoValues(MeteoDatasRecord mdr) { 
            TheTableOfMeteoValues.Add (mdr);
        }

        public void MakePrevisionOfMeteoConditions() {
            for (int i = 0; i < TheTableOfMeteoValues.Count; i++)
            {
                if (TheTableOfMeteoValues[i].InPast == false)
                { 
                    ///make prediction
                    /////and add a new future message in MeteoPrevisions
                }
            }
        }
    }
}
