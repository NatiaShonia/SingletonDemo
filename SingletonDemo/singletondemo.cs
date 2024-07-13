using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {

                    lock (obj)
                    {
                        if (instance == null) //აქ ამოწმებს საერთოდ შექმნილია თუ არა ინსტანსი
                            instance = new Singleton();

                    }
                }


                return instance;

            }
        }




        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value-ctor" + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }


    }

}
