using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog1 = Singleton.Instance;
            Console.WriteLine($"The number of different words in a text file is:{prog1.GetVocabularyCounter()}");
            var prog2 = Singleton.Instance;
            Console.WriteLine($"The word 'mathematics' meets {prog2.GetWordValue("mathematical")} times in a text file");
        }
    }
}
