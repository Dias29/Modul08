using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Building
    {
        private long id;
        private int stageCount;
        private double width;
        private double height;
        private double thickness;
        private string owner;
        private string address;

        private string[] people;

        public string this[int index]
        {
            get
            {
                return people[index];
            }

            set
            {
                people[index] = value;
            }
        }

        public Building()
        {

        }

        public long GetID()
        {
            return id;
        }

        public void SetID(long id)
        {
            this.id = id;
        }

        public long GetStageCount()
        {
            return stageCount;
        }

        public void SetTageCount(int stageCount)
        {
            this.stageCount = stageCount;
        }


    }
}
