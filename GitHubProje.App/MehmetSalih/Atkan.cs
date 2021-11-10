using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubProje.App.MehmetSalih
{
    public class Atkan
    {
        public String uskudar { get; set; }
        public int Kira { get; set; }

        public bool TutulduMu { get; set; }

        public void tutulma(bool TutulduMu)
        {
            if (TutulduMu)
            {
                Console.WriteLine("Hayırlı Olsun");
            }
            else
            {
                Console.WriteLine("Hayırlısı Olsun, takma kafana , olur böyle şeyler, sana ev mi yok  ??");
            }
        }





    }
    }
}
