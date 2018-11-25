using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverDomain.MarsSurface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverDomain.MarsSurface.Tests
{
    [TestClass()]
    public class PlateauTests
    {
        [TestMethod()]
        public void PlateauTest()
        {
            Plateau marsPlateau = new Plateau(5);
            Assert.IsTrue(marsPlateau != null);
        }

        [TestMethod()]
        public void getNeighbourTest()
        {
            Assert.Fail();
        }
    }
}