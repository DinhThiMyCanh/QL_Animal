using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Animal
{
    class Cow : Animal
    {
        public Cow() : base()
        {

        }
        public Cow(string color, int age) : base(color, age)
        {

        }
        public override string animalSound()
        {
            return "Bò kêu ow ow!!!";
        }
    }
}
