﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.BindingModel
{
    public class ProductComponentBindingModel
    {
        public int Id { get; set; }

        public int ComponentId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }
    }
}