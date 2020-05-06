using System;

namespace Indexerexample
{
    public class indexer
    {
        private string[] frnds = new string[5];
        public string this[int i]
        {
            get
            {
                return frnds[i];
            }
            set
            {
                frnds[i] = value;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            indexer obj = new indexer();
           obj[0] = "rajni";
            obj[1] = "purnima";

            for(int i=0;i<2;i++)
            {
                Console.WriteLine(obj[i]);
            }
        }
    }
}
