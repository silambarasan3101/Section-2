using _1._17;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17_
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void StaticFake()
        {
            int x = 10, y = 20;
            var wrapper = new SCalcWrapper();
            Assert.That(wrapper.add(x, y), Is.EqualTo(x + y));
        }

    }
}
