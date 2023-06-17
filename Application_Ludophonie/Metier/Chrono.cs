using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ludophonie.Metier
{
     class Chrono 
    {
        public int heures;
        public int minutes;
        public int secondes;
        public int centieme;

        DateTime temps;
        
        public Chrono()
        {    
            
        }


        public DateTime mecaniqueChrono()
        {
            if(centieme < 100)
            {
                centieme++;
            }
            else
            {
                centieme = 0;
                if (secondes < 59)
                {
                    secondes++;
                }
                else
                {
                    secondes = 0;

                    if (minutes < 60)
                    {
                        minutes++;
                    }
                    else
                    {
                        minutes = 0;
                        if (heures < 100)
                        {
                            heures++;
                        }
                    }
                }

            }



            temps = new DateTime(1, 1, 1, heures, minutes, secondes, centieme);

            return temps;
        }
    }
}
