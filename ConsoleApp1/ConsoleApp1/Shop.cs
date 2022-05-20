using ConsoleApp1.interfaces;
using ConsoleApp1.Man.HighShoe;
using ConsoleApp1.Man.Sneakers.Leather;
using ConsoleApp1.Man.Sneakers.Textile;
using ConsoleApp1.Woman.Boots;
using ConsoleApp1.Woman.LowShoe.Leather;
using ConsoleApp1.Woman.LowShoe.SuedeLeather;
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
                if (list[i].name is TextileSneakersM sneakerst)
                {
                    Console.WriteLine($"Name {sneakerst.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
                    i++;
                }
                else if(list[i].name is LeatherSneakers sneakersl)
                {
                    Console.WriteLine($"Name {sneakersl.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
                    i++;
                }
                else if(list[i].name is HighShoeM HighShoe)
                {
                    Console.WriteLine($"Name {HighShoe.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
                    i++;
                }
                else if(list[i].name is Boots Boot)
                {
                    Console.WriteLine($"Name {Boot.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
                    i++;
                }
                else if(list[i].name is LeatherLowShoeW LowShoel)
                {
                    Console.WriteLine($"Name {LowShoel.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
                    i++;
                }
                else if(list[i].name is SuedeLeatherLowShoeW LowShoesl)
                {
                    Console.WriteLine($"Name {LowShoesl.name}, Size {list[i].name.size}, Manufacturer {list[i].name.manufacturer}, Amount {list[i].amount}");
                    i++;
                }
                else
                {
                    Console.WriteLine($"Name {this.list[i].name.name}, Size {this.list[i].name.size}, Manufacturer {this.list[i].name.manufacturer}, Amount {this.list[i].amount}");
                    i++;
                }                
            }
        }
    }
}
