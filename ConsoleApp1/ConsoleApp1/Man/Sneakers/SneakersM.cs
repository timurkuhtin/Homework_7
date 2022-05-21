using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Man.Sneakers
{
    public class SneakersM: ManShoes, IShoes
    {
        public new string name = "Man Sneakers";
        public string type = "Sneakers";
    }
}
