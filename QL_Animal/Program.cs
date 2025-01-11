using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            DS_Animal list = new DS_Animal();
            Animal animal = new Animal();

            Animal animal1 = new Cat("Meo trang",1);
            animal1.animalSound();
            animal1.Run();
            animal1.Eat();

            Animal animal2 = new Cow("Bo xam",5);
            animal2.animalSound();
            animal2.Run();
            animal2.Eat();

            Animal animal3 = new Cat("Meo den",2);
            animal3.animalSound();
            animal3.Run();
            animal3.Eat();

            list.them(animal1);
            list.them(animal2);
            list.them(animal3);

            list.lietKe();
            Console.ReadKey();
        }
    }
}
