using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentsDetails(),
                () => PrintEmployeeDetails()


                );

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentsDetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
