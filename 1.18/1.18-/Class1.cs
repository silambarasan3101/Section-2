using _1._18;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18_
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void DynamicFake()
        {
            int x = 10, y = 20;
            Mock<IDynamicCalc> mockCalc = new Mock<IDynamicCalc>();
            var result = new
            {
                V = Convert.ToInt32(x + y)
            };
            mockCalc.Setup(c => c.add(It.IsAny<object>(), It.IsAny<object>())).Returns(result);
        }

    }
}
