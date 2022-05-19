using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.interfaces
{
    public interface IBox
    {
        public IShoes name { get; }
        public int amount { get; }
        public void Create(IShoes name, int amount);
    }
}
