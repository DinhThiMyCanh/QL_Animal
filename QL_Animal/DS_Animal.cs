using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QL_Animal
{
    class DS_Animal
    {
        private ArrayList list;
        
        public DS_Animal()
        {
            list = new ArrayList();
        }
        //Them 1 animal vào danh sach
        public void them(Animal animal)
        {
            list.Add(animal);
        }

        //Hien thi danh sach cac con vat
        public void lietKe()
        {
            foreach(Animal animal in list)
            {
                animal.hienThi();
            }    
        }

        
    }
}
