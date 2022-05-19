using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shoes : IShoes
    {
        string name = "Shoes";
        int size = 36;
        string manufacturer = "Nike";
        string IShoes.name => name;

        int IShoes.size => size;

        string IShoes.manufacturer => manufacturer;
    }
}
