using csharp_fundamentals_maps.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps.Test
{
    [TestFixture]
    class CoreTests
    {
        Core exercise;

        public CoreTests()
        {
            this.exercise = new Core();
        }

        [Test]
        public void getValueTest()
        {
            Assert.AreEqual("Nigel", this.exercise.getValue("firstName"));
            Assert.AreEqual("Sibbert", this.exercise.getValue("lastName"));
            Assert.AreEqual("Software Developer", this.exercise.getValue("occupation"));
        }
        [Test]
        public void hasKeyTest()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("firstName", "Nigel");
            map.Add("lastName", "Sibbert");
            map.Add("currentTown", "Bournemouth");

            Assert.IsTrue(this.exercise.hasKey(map, "firstName"));
            Assert.IsTrue(this.exercise.hasKey(map, "lastName"));
            Assert.IsTrue(this.exercise.hasKey(map, "currentTown"));
            Assert.IsFalse(this.exercise.hasKey(map, "dateOfBirth"));
        }
        [TestCase("Pepsi", 3)]
        [TestCase("Sprite", 5)]
        [TestCase("7up", 7)]
        public void getValueOrDefaultTest(string drink, int quantityInFridge)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            map.Add("Pepsi", 3);
            map.Add("Sprite", 5);
            map.Add("7up", 7);

            Assert.IsTrue(this.exercise.getValueOrDefault(map, drink) == quantityInFridge);
        }

        [Test]
        public void buildSecretPhraseTest()
        {
            int[] numbers1 = new int[] { 23, 6712 };
            Assert.AreEqual(this.exercise.buildSecretPhrase(numbers1), new List<string> { "chicken", "bass" });
            int[] numbers2 = new int[] { 6712, 7, 23 };
            Assert.AreEqual(this.exercise.buildSecretPhrase(numbers2), new List<string> { "bass", "muse", "chicken" });
        }

    }
}
