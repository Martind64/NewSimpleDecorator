using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDecoratorPattern
{
    public abstract class Decorator : IPizzaComponent
    {

        protected IPizzaComponent _pizza;

        public Decorator(IPizzaComponent pizza)
        {
            _pizza = pizza;
        }

        public abstract int CalculatePrice();
    }
}
