using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //             Console.WriteLine("Hello World!");
            //             Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            // Create an array of length 10 that alternates between true and false values, starting with true
            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            // Output the length of this list after building it
            // Output the third flavor in the list, then remove this value
            // Output the new length of the list (It should just be one fewer!)
            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor

            int[] array_int = new int[9];
            
            for (int i = 0; i < 9; i++){
                array_int[i] = i + 1;
                Console.Write($"{array_int[i]}> ");
            }
            Console.WriteLine("************");
            string[] array_str = new string[] {"Tim", "Martin", "Nikki",  "Sara"};
            foreach (string ele in array_str){
                Console.Write($"{ele} ");
            }

            bool[] array_boo = new bool[10];
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0) {
                    array_boo[i] = true;
                }else{
                    array_boo[i] = false;
                }
               Console.WriteLine(array_boo[i]); 
            }

            List<string> flavors = new List<string>();
            flavors.Add("sweet1");
            flavors.Add("sweet2");
            flavors.Add("sweet3");
            flavors.Add("sweet4");
            flavors.Add("sweet5");
            foreach (string ele in flavors) {
                Console.WriteLine(ele);
            }
            Console.WriteLine($"flavors length is {flavors.Count}");

        }


       
    }
}
