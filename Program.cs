using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo2
{

    interface IAnimal
    {
        void Eat();
    }

    class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The dog ate!");
        }
    }

    class cow : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The cow ate!");
        }
    }

    class Tiger : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Tiger ate!");
        }
    }

    class Program
    {
        public static void Main()
        {
            IAnimal myDog = new Dog();
            IAnimal mycow = new cow();
            IAnimal myTiger = new Tiger();

            myDog.Eat();
            mycow.Eat();
            myTiger.Eat();
        }
    }
}