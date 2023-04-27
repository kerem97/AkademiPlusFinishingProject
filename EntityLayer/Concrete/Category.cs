﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }

        public bool Status { get; set; }
    }
}
