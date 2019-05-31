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
    public class ProductServiceDB : IProduct
    {
        private StockDBContext context;
        public ProductServiceDB(StockDBContext context)
        {
            this.context = context;
        }
        public List<ProductViewModel> GetList()
        {
            List<ProductViewModel> result = context.Products.Select(rec => new
           ProductViewModel
            {
                Id = rec.Id,
                Название = rec.ProductName,
                
            })
            .ToList();
            return result;
        }
        public ProductViewModel GetElement(int id)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ProductViewModel
                {
                    Id = element.Id,
                    Название = element.ProductName
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(ProductBindingModel model)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.ProductName ==
           model.ProductName);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Products.Add(new Product
            {
                ProductName = model.ProductName
            });
            context.SaveChanges();
        }
        public void UpdElement(ProductBindingModel model)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.ProductName ==
           model.ProductName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            element = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.ProductName = model.ProductName;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Products.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
