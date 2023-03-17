using csharp_fundamentals_maps.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private Extension ext;
        public ExtensionTests()
        {
            ext = new Extension();

        }

        [Test]
        public void PlutoNotAPlanet()
        {
            
            Assert.IsFalse(ext.Planets.ContainsKey("Pluto"));
        }


        [Test]
        [TestCase("Mercury", 0)]
        [TestCase("Venus", 1)]
        [TestCase("Earth", 2)]
        [TestCase("Mars", 3)]
        [TestCase("Jupiter", 4)]
        [TestCase("Saturn", 5)]
        [TestCase("Uranus", 6)]
        [TestCase("Neptune", 7)]
        public void PlanetOrderTest(string planet,int orderfromsun)
        {

            Assert.IsTrue(ext.OrderedPlanets().ToArray()[orderfromsun].Key==planet);
        }

        [Test]
        public void FurthestFromTheSunTest()
        {
            Assert.IsTrue(ext.FurthestFromTheSun().Key == "Neptune");
        }

    }
}
