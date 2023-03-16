
using csharp_fundamentals_maps_exemplar.Main;
using NUnit.Framework;

namespace csharp_fundamentals_maps.Test
{
    public class CoreTest
    {
        Core exercise;

        public CoreTest()
        {
            this.exercise = new Core();
        }

        [Test]
        [TestCase("Nathan", "firstName")]
        [TestCase("King", "lastName")]
        [TestCase("Software Developer", "occupation")]
        public void shouldReturnMappedValues(string expected, string key)
        {
            Assert.AreEqual(expected, this.exercise.createPerson()[key]);
        }

        [Test]
        [TestCase(new string[] { "universe", "bass", "muse" }, new int[] { 42, 6712, 7 })]
        [TestCase(new string[] { "chicken", "nice", "chicken", "soup" }, new int[] { 23, 19, 96, 23, 165 })]
        [TestCase(new string[] { }, new int[] { 918, 71, 88})]
        public void shouldhavecreatedalistofstrings(string[] phrase, int[] array)
        {
            Assert.AreEqual(phrase,this.exercise.buildSecretPhrase(array));
        }
        [Test]
        [TestCase("Earth",true)]
        [TestCase("Venus", false)]
        [TestCase("Jupiter", true)]
        [TestCase("Mercury", true)]        
        public void doeskeyexistinarray(string planet,bool expectedresult)
        {
            Dictionary<string,string> planets = new Dictionary<string,string>();
            planets.Add("Earth", "Its a nice planet which is great to live on");
            planets.Add("Jupiter", "A large planet which isn't too great to live on");
            planets.Add("Mercury", "A warm planet which isn't too great to live on");


            Assert.AreEqual(expectedresult, this.exercise.hasKey(planets, planet));

        }

        [Test]
        [TestCase(true,"RobinReliant",3)]
        [TestCase(true, "Bicycle", 2)]
        [TestCase(true, "Train", -1)]
        public void test(bool expectedresult,string vehicle,int wheelcount)
        {
            Dictionary<string,int> dictionary = new Dictionary<string,int>();
            dictionary.Add("Quad", 4);
            dictionary.Add("Bicycle", 2);
            dictionary.Add("RobinReliant", 3);

            Assert.AreEqual(expectedresult, this.exercise.getValueOrDefault(dictionary, vehicle)==wheelcount);
        }
    }
}