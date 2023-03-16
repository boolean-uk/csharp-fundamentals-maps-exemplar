using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps_exemplar.Main
{
    public class Exercise
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



        /*
            2. Create a method named hasKey that accepts two parameters:
            - A HashMap of String, String key value pairs
            - A string
            The method must return a boolean that represents whether the string provided exists as a key
            in the provided HashMap
         */



        /*
            3. Create a method named getValueOrDefault that accepts two parameters:
            - A HashMap of String, Integer key value pairs
            - A string
            The method must use the string provided to return the integer contained in the provided HashMap,
            or -1 if the string provided is not a key in the HashMap
         */



        /*
            4. Complete the method below
            Example input & output:
            input                       output
            [42, 6712, 7]           |   ArrayList<String> ["universe", "bass", "muse"]
            [23, 19, 96, 23, 165]   |   ArrayList<String> ["chicken", "nice", "chicken", "soup"]
            [918, 71, 88]           |   ArrayList<String> []
         */
        public ArrayList<String> buildSecretPhrase(ArrayList<Integer> numbers)
        {
            // Do not modify the map
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.put(23, "chicken");
            map.put(42, "universe");
            map.put(165, "soup");
            map.put(6712, "bass");
            map.put(7, "muse");
            map.put(96, "nice");
            // Write your code below this comment...




            // ...and above this comment
        }

        public double getValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}
