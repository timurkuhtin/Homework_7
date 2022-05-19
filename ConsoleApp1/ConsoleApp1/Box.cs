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
        public int amount;

        IShoes IBox.name => throw new NotImplementedException();

        int IBox.amount => throw new NotImplementedException();

        public void Create(IShoes name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }
}
