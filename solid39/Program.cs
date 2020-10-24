using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid39
{
    class Animal { }
    class Dog : Animal { }

    class Program
    {
        static void PrintTypes(Animal a)
        {
            Console.WriteLine(a.GetType());//ExType.Dog
            Console.WriteLine(typeof(Animal));//ExType.Animal
            Console.WriteLine(typeof(Dog));//ExType.Dog
            Console.WriteLine(a.GetType() == typeof(Animal));//False 
            Console.WriteLine(a is Animal);//True 
            Console.WriteLine(a.GetType() == typeof(Dog));//True
        }
        static void Main(string[] args)
        {
            Dog spot = new Dog();
            PrintTypes(spot);
        }
    }


}
