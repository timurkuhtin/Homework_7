using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Man.Sneakers.Leather
{
    public class LeatherSneakers: SneakersM, IShoes
    {
        public new string name = "Man Leather Sneakers";
        public string material = "Leather";
    }
}
