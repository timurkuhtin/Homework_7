using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Box: IBox
    {
        public IShoes name;
        public int amount = 1;

        IShoes IBox.name => name;

        int IBox.amount => amount;

        public void Create(IShoes name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }
}
