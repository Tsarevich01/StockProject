﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockProject
{
    public class Stock
    {
        public int Id { get; set; }

        [ForeignKey("StockId")]
        public virtual List<StockComponent> StockComponents { get; set; }
    }
}