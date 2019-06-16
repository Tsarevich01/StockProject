﻿using StockData;
using StockProject;
using StockProjectDAL.BindingModel;
using StockProjectDAL.Interface;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDB.Implementations
{
    public class StockServiceDB : IStock
    {
        private StockDataContext context;
        public StockServiceDB(StockDataContext context)
        {
            this.context = context;
        }
        public List<StockViewModel> GetList()
        {
            List<StockViewModel> result = context.Stocks.Select(rec => new
           StockViewModel
            {
                Id = rec.Id,
            })
            .ToList();
            return result;
        }


        public void DelElement(int id)
        {
            Stock element = context.Stocks.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Stocks.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }


        public StockViewModel GetElement(int id)
        {
            Stock element = context.Stocks.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new StockViewModel
                {
                    Id = element.Id,
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void Stock(StockBindingModel stockBindingModel)
        {
            throw new NotImplementedException();
        }

        public void Stock(StockComponentBindingModel stockComponentBindingModel)
        {
            throw new NotImplementedException();
        }
    }
}
