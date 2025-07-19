using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal class Car
    {
        #region Attributes
        private int id;
        private int speed;
        private string model;

        //ctor
        //public Car()
        // {

        // }
        #endregion

        public Car(int id, int speed, string model)
        {
            Id = id;
            Speed = speed;
            Model = model;  

        }
        #region properties
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public int Speed
        {
            set
            {
                speed = value;
            }
            get
            {
                return speed;
            }
        }
        public string Model
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }

        #endregion






    }
}
