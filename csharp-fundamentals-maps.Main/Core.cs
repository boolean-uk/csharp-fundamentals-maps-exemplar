using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps_exemplar.Main
{
    public class Core
    {
        /*
    The final fundamental building block of C# is a Map. There is still much to learn about the language,
    but this component will allow you to start building lots of more complex pieces of software.
    A map is like a list, except we have control over what we use for an item's index. This allows us to use
    types other than an incrementing integer to describe the positions of the data contained in the structure.
    Like Lists, Maps have a variety of different implementations. We'll focus on the HashMap in this exercise.
    We create a HashMap like this:
    HashMap<K, V>
    K is where you'd put the data type of the key for an item, V is the data type of the value.
    If we wanted to map a persons details (their first name, last name, occupation etc.), we could use
    a HashMap using a String key and a String value like so:
    HashMap<String, String>
 */

        /*
            Spend some time understanding the method below
            - It creates a Map of String, String key value pairs
            - It adds some keys with values
            - Under the hood, the Dictionary would look like this: { "firstName": "Nathan", "lastName": King, etc. }
            - It returns the Dictionary
            
         */
        public Dictionary<string, string> createPerson()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("firstName", "Nathan");
            map.Add("lastName", "King");
            map.Add("occupation", "Software Developer");

            return map;
        }

        /*
            1. Create a method named getValue that accepts one parameter:
            - a string key
            The method must return the value associated to the provided key from the HashMap created
            in the createPerson method
         */

        public string getValue(string key)
        {
            var dict = this.createPerson();

            return dict[key];
            
        }

          //TODO:  2. Create a method named hasKey that accepts two parameters:
        /*
            - A Dictionary of string, string key value pairs            
            - string
            The method must return a boolean that represents whether the string provided exists as a key
            in the provided HashMap
         */
         public bool hasKey(Dictionary<string,string> dictionary, string isitthere)
         {
            return dictionary.ContainsKey(isitthere);
         }


        /*
            3. Create a method named getValueOrDefault that accepts two parameters:
            - A Dictionary<string,integer>
            - A string
            The method must use the string provided to return the integer contained in the provided HashMap,
            or -1 if the string provided is not a key in the HashMap
         */
        public int getValueOrDefault(Dictionary<string,int> dictionary, string isitthere)
        {            
            return dictionary.TryGetValue(isitthere, out int actual) ? actual : -1;
            
        }


        /*
            4. Complete the method below
            Example input & output:
            input                       output
            [42, 6712, 7]           |   ArrayList<String> ["universe", "bass", "muse"]
            [23, 19, 96, 23, 165]   |   ArrayList<String> ["chicken", "nice", "chicken", "soup"]
            [918, 71, 88]           |   ArrayList<String> []
         */
        public string[] buildSecretPhrase(int[] numbers)
        {
            // Do not modify the map
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(23, "chicken");
            map.Add(42, "universe");
            map.Add(165, "soup");
            map.Add(6712, "bass");
            map.Add(7, "muse");
            map.Add(96, "nice");
            // Write your code below this comment...
                        
            int elements = 0;
            foreach(int i in numbers)
            {
                if (map.ContainsKey(i))
                {
                    elements++;
                }
            }
            
            string[] result = new string[elements];
            int y = 0;
            foreach(int x in numbers)
            {
                if(map.ContainsKey(x))
                {
                    result[y]=map[x];
                    y++;
                }

                
            }
            return result;
            

            //    // ...and above this comment
        }            
    }
}
