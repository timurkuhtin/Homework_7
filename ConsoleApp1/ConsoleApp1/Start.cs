﻿using ConsoleApp1.Man.Sneakers.Textile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Start
    {
        public void Go()
        {
            Box asd = new Box();
            Shop shop = new Shop();
            TextileSneakersM Sneakers = new TextileSneakersM();
            asd.Create(Sneakers, 10);
            shop.AddToList(asd);
            shop.WriteList();
        }
    }
}
