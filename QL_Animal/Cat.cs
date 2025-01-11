using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Animal
{
    class Cat:Animal
    {

        public Cat(): base()
        {

        }
        public Cat(string color, int age): base(color,age)
        {

        }
   /*     public override string animalSound()
        {
            return "Mèo kêu meo meo!!";
        }*/
        
        //Phuong thuc an
        public override string Eat()
        {
            return "Mèo ăn cá";
        }
    }
}
