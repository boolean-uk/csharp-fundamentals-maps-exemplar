using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps.Main
{
    public  class Extension
    {
        private Dictionary<string, float> _planets;

        public Extension()
        {
            _planets = new Dictionary<string, float>();
            _planets.Add("Jupiter", 5.2f);
            _planets.Add("Uranus", 19.2f);
            //_planets.Add("Pluto", 39f);
            _planets.Add("Mercury", 0.39f);
            _planets.Add("Saturn", 9.54f);
            _planets.Add("Earth", 1f);
            _planets.Add("Mars", 1.52f);
            _planets.Add("Venus", 0.72f);
            _planets.Add("Neptune", 30.06f);
            //TODO 1.  Pluto is unfortunately no longer a planet so please comment out the add line!
        }

        
        public Dictionary<string,int> LettersInName()
        {
            throw new NotImplementedException();
           // Dictionary<string, int> result = new Dictionary<string, int>();
            
            //TODO 2.  Complete this method to return an Dictionary of <string,int> which contains 
            //          the planet name and the number of letters in its name
            //          iterate the _planets using a foreach object to load the result dictionary.



            //return result;
        }





        public Dictionary<string,float> Planets { get { return _planets; } }

        public Dictionary<string,float> OrderedPlanets()
        {           
                return _planets.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);                           
        }

        //       By examining the code in the OrderedPlanets method you can see how the original planet dictionary
        //       has been ordered so the planets are in ascending order of AU (the float value in the pair).
        //TODO:3 See if you can order the _planets dictionary DESCENDING and return the .First() element in a 
        //       one line return, thus returning the last planet from the sun.
        //       Note how you could copy line 52, add .Last() and paste into the method
        //       to achieve this without changing the OrderBy!


        public KeyValuePair<string,float> FurthestFromTheSun()
        {
            //throw new NotImplementedException();
            return _planets.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).First();
        }


    }
}
