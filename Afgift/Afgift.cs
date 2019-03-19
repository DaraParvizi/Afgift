using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afgift
{
    public class Afgift
    {
         public double BilAfgift(int pris)
        {
            if (pris > 200000)
            {
                return  pris * 0.85;
            }
            else 
            {
                return (pris * 1.50) - 130000;
            }
          
        }

        public double
            ElBilAfgift(int pris)
        {
            return BilAfgift(pris) * 0.20;
        }
    }
}
