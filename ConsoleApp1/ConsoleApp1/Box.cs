using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Box
    {
        public Shoes name;
        public int amount;

        public void create(Shoes name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }
}
