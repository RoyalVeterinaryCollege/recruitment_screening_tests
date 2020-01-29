using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feel free to run this code, but please don't change it
            Implementation.CountOfCode1(DataSource.GetSomeUniqueAnimals().ToList());
            Implementation.ReturnUniqueCodes(DataSource.CreateSomeCodes(30).ToList());
            Implementation.AnimalsInBothLists(DataSource.GetSomeUniqueAnimals().ToList(), DataSource.GetSomeUniqueAnimals().ToList());
            Implementation.AnimalsOnlyInA(DataSource.GetSomeUniqueAnimals().ToList(), DataSource.GetSomeUniqueAnimals().ToList());
            Implementation.CountOfCode1And2(DataSource.GetSomeUniqueAnimals().ToList());
            Console.WriteLine("Program completed.  Press any key.");
            Console.ReadLine();
        }
    }
}
