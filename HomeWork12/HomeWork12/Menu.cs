using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public class Menu
    {
        public void InputDay()
        {
            Console.Write("Input number from 1 to 365: ");
        }

        public int ReadDay()
        {

            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day > 366)
            {
                throw new IndexOutOfRangeException("Entered value is out of range!!! Enter number from 1 to 366");
            }
            else
            {
                return day;
            }
            //return Convert.ToInt32(Console.ReadLine());
        }
        public void InputYear()
        {
            Console.Write("Input year: ");
        }
        public int ReadYear()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
