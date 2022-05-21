using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Man.Sneakers.Textile
{
    public class TextileSneakersM: SneakersM, IShoes
    {
        public string name = "Man Textile Sneakers";
        public string material = "Textile";
        public new void TryOn()
        {
            int result = new Random().Next(1, 3);
            if(result == 0)
            {
                Console.WriteLine("Size fits");
            }
            else
            {
                Console.WriteLine("Size does not fit");
            }
        }
    }
}
