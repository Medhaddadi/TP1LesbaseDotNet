using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TP1LesbaseDotNet
{
    class Program 
    {
       public static void Main(string[] args)
        {
            Dichotomie dichotomie = new Dichotomie();
            dichotomie.solveDichotomie(-1000, 1000, 1 * Math.Exp(-15));
          /*  dichotomie.solveDichotomie(-2.5, 2,-0.25); */
            Console.WriteLine("hi");
            dichotomie.afficher(); 
                
        }

       
    }
}
