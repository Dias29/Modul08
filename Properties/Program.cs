using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.ID = 2; //автоматический вызывается set
            long id = item.ID; //автоматический вызывается get

            int[] numbers = new int[] { 1, 2, 2, 3, 2, 4, 43, 4, 5 };  //object initializier

            Item itemSecond = new Item()
            {
                ID = 1,
                Name = "Товар 1",
                Price = 100

            };

            ArrayList list = new ArrayList();
            list.Add(1);
            int number = (int)list[0];

            Building building = new Building();
            building[0] = "Вася";

        }
    }
}
