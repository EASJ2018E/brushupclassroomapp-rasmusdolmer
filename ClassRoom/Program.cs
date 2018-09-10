using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum kr = new KlasseRum();
            kr.KlasseNavn = "3B";
            kr.SemesterStart = Convert.ToDateTime("04-09-2018");

            Studerende s1 = new Studerende("Rasmus",7, 1998);
            Studerende s2 = new Studerende("Lucas", 7, 1997);

            kr.Klasseliste = new List<Studerende>();
            kr.Klasseliste.Add(s1);
            kr.Klasseliste.Add(s2);

            foreach (var studerende in kr.Klasseliste)
            {
                Console.WriteLine(studerende.Navn + "\n" + studerende.Fødselsmåned + ", " + studerende.Fødselsår +
                                  "\n" + studerende.Årstid(studerende.Fødselsmåned) + "\n");
            }
            kr.AntalStudIÅrstider();
        }
    }
}
