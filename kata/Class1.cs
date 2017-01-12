using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    public class readDictionary
    {
        Dictionary<int, string> newDictionary = new Dictionary<int, string>();

        public void ReadIt()
        {
            // Open the file into a streamreader
            using (StreamReader sr = new StreamReader("dictionary.txt"))
            {
                int i = 0;
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    //read each line
                    string word = sr.ReadLine();

                    //add it to the dictionary
                    newDictionary.Add(i, word);

                    //iterate
                    i++;
                }
            }
        }
    }
}
