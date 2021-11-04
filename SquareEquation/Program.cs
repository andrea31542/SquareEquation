using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            // because QuadreaticEquation is private, is is not possible to use qe.a
            Console.WriteLine(qe.A);
            //qe.A = 10; is not possible because it does not have set method

            var roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);


            qe = new QuadraticEquation(-1, 2, -1);
            roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);

            Console.ReadKey(false); 



        }
    }
}
