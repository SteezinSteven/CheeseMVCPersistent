﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseMenu
    {
        public Cheese Cheese { get; set; }
        public int CheeseID { get; set; }

        public Menu Menu { get; set; }
        public int MenuID { get; set; }

        IList<CheeseMenu> CheeseMenus = new List<CheeseMenu>();
    }
}
