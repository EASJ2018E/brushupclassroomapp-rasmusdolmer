using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            
        }

        public void AntalStudIÅrstider()
        {
            var studVinterCount = (from stud in Klasseliste where stud.Fødselsmåned == 12 || stud.Fødselsmåned <= 2 select stud).Count();
            Console.WriteLine("Vinter: " + studVinterCount);
            var studForårCount = (from stud in Klasseliste where stud.Fødselsmåned >= 3 && stud.Fødselsmåned <= 5 select stud).Count();
            Console.WriteLine("Forår: " + studForårCount);
            var studSommerCount = (from stud in Klasseliste where stud.Fødselsmåned >= 6 && stud.Fødselsmåned <= 8 select stud).Count();
            Console.WriteLine("Sommer: " + studSommerCount);
            var studEfterårCount = (from stud in Klasseliste where stud.Fødselsmåned >= 9 && stud.Fødselsmåned <= 11 select stud).Count();
            Console.WriteLine("Eferår: " + studEfterårCount);
        }
    }
}
