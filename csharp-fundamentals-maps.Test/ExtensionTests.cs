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
        public void LettersInNameTest()
        {
            if (ext.LettersInName().Count == 0)
            {
                Assert.Fail();
            }
            foreach (KeyValuePair<string, int> item in ext.LettersInName())
            {
                Assert.IsTrue(item.Key.Length == item.Value);
            }
        }

        [Test]
        [TestCase("Mercury", 7)]
        [TestCase("Venus", 6)]
        [TestCase("Earth", 5)]
        [TestCase("Mars", 4)]
        [TestCase("Jupiter", 3)]
        [TestCase("Saturn", 2)]
        [TestCase("Uranus", 1)]
        [TestCase("Neptune", 0)]
        public void PlanetOrderTest(string planet, int orderfromsun)
        {

            Assert.IsTrue(ext.OrderedPlanetsByDescending().ToArray()[orderfromsun].Key == planet);
        }


        [Test]
        public void FurthestFromTheSunTest()
        {
            Assert.AreEqual(ext.FurthestFromTheSun().ToLower(), "neptune");
        }
        [Test]
        public void ClosestToTheSunTest()
        {
            Assert.AreEqual(ext.ClosestToTheSun().ToLower(), "mercury");
        }

    }
}
