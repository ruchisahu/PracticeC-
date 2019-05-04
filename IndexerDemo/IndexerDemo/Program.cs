using System;

namespace IndexerDemo
{
    class SentenceIndexer
    {
        string[] words = "The quick lazy fox jump over".Split();
        public string this[int wordNUm]
        {
            get
            {
                return words[wordNUm];
            }
            set
            {
                words[wordNUm] = value;
            }
        }
        static void Main(string[] args)
        {
            SentenceIndexer sen = new SentenceIndexer();
            Console.WriteLine(sen[3]);
            sen[1]= "change";
            Console.WriteLine(sen[1]);
            Console.WriteLine("Hello World!");
        }
    }
}
