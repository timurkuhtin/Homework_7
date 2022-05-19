using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IShoes
    {
        public string name { get; }
        public int size { get; }
        public string manufacturer { get; }
    }
}
