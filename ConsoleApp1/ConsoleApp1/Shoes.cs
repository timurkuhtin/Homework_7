﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shoes : IShoes
    {
        string IShoes.name => "Shoes";

        int IShoes.size => 36;

        string IShoes.manufacturer => "Nike";
    }
}
