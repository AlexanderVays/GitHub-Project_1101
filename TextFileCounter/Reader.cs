using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCounter
{
    class Reader
    {
        public static Dictionary<string, int> resultDictionary = new Dictionary<string, int>();

        public static void GetCount(List<string> strList, bool caseSensitive) 
        {
            MainForm mf = new MainForm();
            bool fileExists = mf.ValidateTextFile();
            List<string> myList = new List<string>();
            foreach (string s in strList) 
            {
                resultDictionary.Add(s, 0);
            }

            if (fileExists)
            {
                string[] lines = File.ReadAllLines(MainForm.fileName);
                if (caseSensitive)
                {
                    foreach (string str in lines)
                    {
                        foreach (string word in strList)
                        {
                            if (str.Contains(word))
                            {
                                resultDictionary[word] += str.Count(word.Contains);
                            }
                        }
                    }

                    /*
                    foreach (KeyValuePair<string, int> entry in resultDictionary)
                    {
                        Console.WriteLine($"The word ({entry.Key}) appeared in text {entry.Value} times");
                    }
                    */
                }
                else
                {
                    foreach (string str in lines)
                    {
                        foreach (string word in strList)
                        {
                            if (str.ToLower().Contains(word.ToLower()))
                            {
                                resultDictionary[word] += str.Count(word.Contains);
                            }
                        }
                    }

                    /* foreach (KeyValuePair<string, int> entry in resultDictionary)
                    {
                        Console.WriteLine($"The word ({entry.Key}) appeared in text {entry.Value} times");
                    } */
                }
            }
        }
    }
}
