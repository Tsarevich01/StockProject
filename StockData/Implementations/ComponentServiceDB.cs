using StockData;
using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockDB.Implementations
{
    public class ComponentServiceDB : StockProjectDAL.Interface.IComponent
    {
        private StockDataContext context;
        public ComponentServiceDB(StockDataContext context)
        {
            this.context = context;
        }
        public List<ComponentViewModel> GetList()
        {
            List<ComponentViewModel> result = context.Component.Select(rec => 
            new ComponentViewModel
            {
                Id = rec.Id,
                Наименование = rec.ComponentName,
                Штрихкод = rec.Barcode
            })
            .ToList();
            return result;
        }
        public ComponentViewModel GetElement(int id)
        {
            StockProject.Component element = context.Component.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ComponentViewModel
                {
                    Id = element.Id,
                    Наименование = element.ComponentName,
                    Штрихкод = element.Barcode
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(ComponentBindingModel model)
        {
            StockProject.Component element = context.Component.FirstOrDefault(rec => rec.ComponentName ==
           model.ComponentName);
            if (element != null)
            {
                throw new Exception("Уже есть поставщик с таким ФИО");
            }
            context.Component.Add(new StockProject.Component
            {
                ComponentName = model.ComponentName,
                Barcode = model.Barcode
            });
            context.SaveChanges();
        }
        public void UpdElement(ComponentBindingModel model)
        {
            StockProject.Component element = context.Component.FirstOrDefault(rec => 
                                                rec.ComponentName == model.ComponentName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть поставщик с таким ФИО");
            }
            element = context.Component.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.ComponentName = model.ComponentName;
            element.Barcode = model.Barcode;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            StockProject.Component element = context.Component.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Component.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
