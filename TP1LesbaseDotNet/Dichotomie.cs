using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1LesbaseDotNet
{
    internal class Dichotomie : Function
    {
        private double a;
        private double b;
        private double prec;
        public Dichotomie() {

        }

        public double computeFunctionValue(double d)
        {
            /*  return Math.Pow(d, 5) + 3 * Math.Pow(d, 4) + 2 * Math.Pow(d, 3) + Math.Pow(d, 2) + 3 * d + 1;*/
            return Math.Pow(d, 3) - 3 * d + 1;
        }

        public  void solveDichotomie (double a, double b , double prec )
        {
            while ((b-a)>prec)
            {
                double c = (a + b) / 2;
                if (computeFunctionValue(a)*computeFunctionValue(c)<=0)
                {
                   b= c;
                }else
                    a=c;

            }
            this.a = a;
            this.b = b;
            this.prec = prec;
        }
        public void afficher()
        {
            Console.WriteLine("a = " + this.a + " b = " + b);
        }

    }
}
