using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Navn { get; set; }
        public int Fødselsmåned { get; set; }
        public int Fødselsår { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselsår)
        {
            Navn = navn;
            if (Fødselsmåned > 0 || Fødselsmåned < 13)
            {
                Fødselsmåned = fødselsmåned;
            }
            
            Fødselsår = fødselsår;  
        }

        public string Årstid(int fødselsmåned)
        {
            if (fødselsmåned <= 2 || fødselsmåned == 12)
            {
                return "Vinter";
            }
            if (fødselsmåned >= 3 && fødselsmåned <= 5)
            {
                return "Forår";
            }
            if (fødselsmåned >= 6 && fødselsmåned <= 8)
            {
                return "Sommer";
            }
            if (fødselsmåned >= 9 && fødselsmåned <= 11)
            {
                return "Efterår";
            }

            return null;
        }
    }
}
