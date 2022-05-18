using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shop
    {
        public Box[] list = new Box[10];

        public Box[] FindSize(Box[] list, int size)
        {
            Box[] result = new Box[10];
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i].name.size == size)
                {
                    result[i] = list[i];
                }
            }
            return result;
        }
        public Box[] FindManufacturer(Box[] list, string manufacturer)
        {
            Box[] result = new Box[10];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].name.manufacturer == manufacturer)
                {
                    result[i] = list[i];
                }
            }
            return result;
        }
        public void create(Box name)
        {
            for(int i = 0; i < 10; i++)
            {
                if (list[i] != ) 
                { 
                    this.list = name;
                }
                
            }
                
        }
        public void writelist(Box[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"Name {list[i].name.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
            }
        }
    }
}
