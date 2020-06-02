using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Singleton class is completely thread-safe. It is loaded in a "Lazy" way which means that our instance is going to be created only when it is actually needed. 
    public sealed class Singleton : ISingleton
    {
        
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance => instance.Value;

        private Dictionary<string, int> vocabulary = new Dictionary<string, int>();
        public string fileName { get; set; }

        private Singleton() 
        { 
        }

        public Dictionary<string, int> GetRead(string fileName) 
        {
            return vocabulary;
        }
    }
}
