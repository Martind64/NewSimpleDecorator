using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoratorPattern
{
    class Cheese : Decorator
    {
        public Cheese(IPizzaComponent pizza): base(pizza)
        {
        }


        public override int CalculatePrice()
        {
            return _pizza.CalculatePrice() + 5;
        }

        public override string ToString()
        {
            return _pizza + ", Cheese";
        }
    }
}
