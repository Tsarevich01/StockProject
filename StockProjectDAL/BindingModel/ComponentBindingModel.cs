﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.BindingModel
{
    public class ComponentBindingModel
    {
        public int Id { get; set; }

        public string ComponentName { get; set; }

        public int Barcode { get; set; }
    }
}
