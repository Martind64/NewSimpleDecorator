using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoratorPattern
{
    class Ham : Decorator
    {
        public Ham(IPizzaComponent pizza): base(pizza)
        {
        }


        public override int CalculatePrice()
        {
            return _pizza.CalculatePrice() + 5;
        }

        public override string ToString()
        {
            return _pizza + ", Ham";
        }
    }
}
