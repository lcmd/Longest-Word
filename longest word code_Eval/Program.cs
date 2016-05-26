using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_word_code_Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "my middle name is champagne"; //my name is dope

            string[] words = line.Split(); // initializing a new string array and assigning it to split line
            string longest = ""; //initializing another string called longest. its value is empty

            foreach (string word in words) //create a foreach loop and declare a new string called word
            {
                if (word.Length > longest.Length) //begin an if statement, comparing length of string word to length of string longest
                    longest = word;              //no {} b/c one line statement, reassign string longest to word with the greatest value
            }
            Console.WriteLine(longest);         //will print whichever word has the most characters
            Console.WriteLine(longest.Length);  //will print the number of characters for your longest word

        }
    }
}
