using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Animal
{
    abstract class Animal
    {
        protected string color;
        protected int age;

        public Animal()
        {
            this.color = "";
            this.age = 0;
        }
        public Animal(string color, int age)
        {
            this.color = color;
            this.age = age;
        }

        abstract public string animalSound();
        public string Run()
        {
           return "Chạy bằng 4 chân";
        }
        public virtual string Eat()
        {
            return "Động vật ăn cỏ";
        }

        public void hienThi()
        {
            Console.WriteLine("Mau sac:{0} tuoi:{1}", color, age);
            Console.WriteLine(animalSound());
            Console.WriteLine(Run());
            Console.WriteLine(Eat());
        }

        
    }
}
