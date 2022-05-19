using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Man.Sneakers.Textile
{
    public class TextileSneakersM: SneakersM, IShoes
    {
        public new string name = "Man Textile Sneakers";
        public string material = "Textile";
    }
}
