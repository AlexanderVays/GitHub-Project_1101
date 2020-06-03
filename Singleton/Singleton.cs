using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// The Singleton is a creational design pattern that allows us to create a single instance of an object and to share that instance with all the users that require it.
    /// Current singleton class is completely thread-safe. It is loaded in a "Lazy" way which means that our instance is going to be created only when it is actually needed.
    /// </summary>
    public sealed class Singleton : ISingleton
    {
        
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance => instance.Value;

        private Dictionary<string, int> vocabulary = new Dictionary<string, int>();
        public string fileName { get; set; } = "mathematics.txt";

        private Singleton() 
        {
            Console.WriteLine("Initializing singleton object");

            string content = File.ReadAllText(fileName);
            string[] words = content.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (!vocabulary.ContainsKey(words[i]))
                {
                    vocabulary.Add(words[i], 0);
                }
                else
                {
                    vocabulary[words[i]] += 1;
                }
            }
        }

        //Load the dictionary with words as a key and counter for each specific word
        public void GetVocabulary(string fileName) 
        {
            
        }

        //return a vocabulary counter
        public int GetVocabularyCounter() 
        {
            return vocabulary.Count;
        }

        //return a value (counter) of a specific word (key)
        public int GetWordValue(string word) 
        {
            return vocabulary[word];
        }
    }
}
