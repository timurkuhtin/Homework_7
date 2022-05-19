using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shop
    {
        public IBox[] list = new IBox[10];

        public Box[] FindSize(IBox[] list, int size)
        {
            Box[] result = new Box[10];
            for(int i = 0; i < list.Length; i++)
            {
                if(list[i].name.size == size)
                {
                    result[i] = (Box)list[i];
                }
            }
            return result;
        }
        public Box[] FindManufacturer(IBox[] list, string manufacturer)
        {
            Box[] result = new Box[10];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].name.manufacturer == manufacturer)
                {
                    result[i] = (Box)list[i];
                }
            }
            return result;
        }
        public void AddToList(IBox name)
        {
            for(int i = 0; i < 10; i++)
            {
                if (this.list[i] == null)
                {
                    this.list[i] = name;
                    break;
                }

            }
                
        }
        public void WriteList()
        {
            int i = 0;
            while (list[i] != null)
            {
                Console.WriteLine($"Name {this.list[i].name.name}, Size {this.list[i].name.size}, Manufacturer {this.list[i].name.manufacturer}, Amount {this.list[i].amount}");
                i++;
            }
        }
    }
}
