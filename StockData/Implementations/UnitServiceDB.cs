using StockData;
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
    public class UnitServiceDB : IUnit
    {
        private StockDataContext context;
        public UnitServiceDB(StockDataContext context)
        {
            this.context = context;
        }
        public List<UnitViewModel> GetList()
        {
            List<UnitViewModel> result = context.Units.Select(rec => new
           UnitViewModel
            {
                Id = rec.Id,
                Наименование = rec.UnitName
            })
            .ToList();
            return result;
        }
        public UnitViewModel GetElement(int id)
        {
            Unit element = context.Units.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new UnitViewModel
                {
                    Id = element.Id,
                    Наименование = element.UnitName
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(UnitBindingModel model)
        {
            Unit element = context.Units.FirstOrDefault(rec => rec.UnitName ==
           model.UnitName);
            if (element != null)
            {
                throw new Exception("Уже есть такая ЕИ");
            }
            context.Units.Add(new Unit
            {
                UnitName = model.UnitName
            });
            context.SaveChanges();
        }
        public void UpdElement(UnitBindingModel model)
        {
            Unit element = context.Units.FirstOrDefault(rec => rec.UnitName ==
           model.UnitName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть такая ЕИ");
            }
            element = context.Units.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.UnitName = model.UnitName;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Unit element = context.Units.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Units.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
