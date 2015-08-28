using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication2;
using NUnit.Framework;
namespace WebApplication2Tests
{
    [TestFixture]
    public class WebApplication2Tests
    {
        [Test]
        public void EquilateralTriangleTest()
        {            
            Assert.AreEqual(TriangleType.Equilateral, TriangleTester.GetTriangleType(1,1,1));
        }
    }
}
