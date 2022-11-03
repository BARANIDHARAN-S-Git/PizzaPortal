using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PizzaPotal;
using PizzaPotal.Models;

namespace Test
{
    [TestFixture]
    public class test
    {
        pizzatype p = null;
        public test()
        {
            p = new pizzatype();
        }

        [TestCase(ExpectedResult =6)]
        [TestCase(ExpectedResult =7)]
        public int check(int qnty)
        {

            p.add();
            return (p.pizza.Count);
            
        }
    }
}
