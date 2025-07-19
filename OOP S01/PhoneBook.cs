using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;



        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];


                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }
        }
        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }
        public void addPerson(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;    
        }

        public long getNumbers(string name)
        {
            for(int i=0; i<names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
                

            }
            return -1;
        }

        public void updateNumber(string name, long newNumber)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newNumber;
            }
        }



    }
}
