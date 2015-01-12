using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePizza pizza = new BasePizza();

            Cheese cheese = new Cheese(pizza);
            Ham ham = new Ham(cheese);

            Console.WriteLine(ham);
            Console.WriteLine(ham.CalculatePrice());

        }
    }
}
