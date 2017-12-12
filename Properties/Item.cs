using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Item
    {
        private DateTime creationDate;

        #region Properties
        //public возвр_тип Имя {get; set}
        public long ID { get;  set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public DateTime CreationDate        //полное свойство
        {
            get
            {
                //тут много разных действий
                return creationDate;
            }

            set
            {
                //тут много разных действий
                creationDate = value;
            }
        }
#endregion
    }
}
