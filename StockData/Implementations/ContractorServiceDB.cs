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
    public class ContractorServiceDB : IContractor
    {
        private StockDataContext context;
        public ContractorServiceDB(StockDataContext context)
        {
            this.context = context;
        }
        public List<ContractorViewModel> GetList()
        {
            List<ContractorViewModel> result = context.Contractors.Select(rec => new
           ContractorViewModel
            {
                Id = rec.Id,
                ContractorName = rec.ContractorName,
                Code = rec.Code,
                ContractorEmail = rec.ContractorEmail,
                Tel = rec.Tel,
                UrAdres = rec.UrAdres
            })
            .ToList();
            return result;
        }
        public ContractorViewModel GetElement(int id)
        {
            Contractor element = context.Contractors.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ContractorViewModel
                {
                    Id = element.Id,
                    ContractorEmail = element.ContractorEmail,
                    ContractorName = element.ContractorName,
                    Code = element.Code,
                    Tel = element.Tel,
                    UrAdres = element.UrAdres
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(ContractorBindingModel model)
        {
            Contractor element = context.Contractors.FirstOrDefault(rec => rec.ContractorName ==
           model.ContractorName);
            if (element != null)
            {
                throw new Exception("Уже есть заказчик с таким названием");
            }
            context.Contractors.Add(new Contractor
            {
                ContractorName = model.ContractorName,
                Code = model.Code,
                ContractorEmail = model.ContractorEmail,
                Tel = model.Tel,
                UrAdres = model.UrAdres
            });
            context.SaveChanges();
        }
        public void UpdElement(ContractorBindingModel model)
        {
            Contractor element = context.Contractors.FirstOrDefault(rec => rec.ContractorName ==
           model.ContractorName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть заказчик с таким названием");
            }
            element = context.Contractors.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.ContractorName = model.ContractorName;
            element.Code = model.Code;
            element.ContractorEmail = model.ContractorEmail;
            element.Tel = model.Tel;
            element.UrAdres = model.UrAdres;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Contractor element = context.Contractors.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Contractors.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
