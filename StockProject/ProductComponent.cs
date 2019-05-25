﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockProject
{
    public class ProductComponent
    {
        public int Id { get; set; }

        public int ComponentId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public virtual Product Product { get; set; }

        public virtual Component Component { get; set; }
    }
}