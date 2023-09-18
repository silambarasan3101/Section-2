using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace _1._7
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void ArrangeActAssert()
        {
            var calc = new Calculator();
            var answer = calc.add(5, 19);

            Assert.That(answer, Is.EqualTo(24));
        }



    }
}
