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
    public class PersonServiceDB : IPerson
    {
        private StockDBContext context;
        public PersonServiceDB(StockDBContext context)
        {
            this.context = context;
        }
        public List<PersonViewModel> GetList()
        {
            List<PersonViewModel> result = context.Persons.Select(rec => new
           PersonViewModel
            {
                Id = rec.Id,
                Login = rec.Login,
                Password = rec.Password,
                PersonFIO = rec.PersonFIO
            })
            .ToList();
            return result;
        }
        public PersonViewModel GetElement(int id)
        {
            Person element = context.Persons.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new PersonViewModel
                {
                    Id = element.Id,
                    Login = element.Login,
                    Password = element.Password,
                    PersonFIO = element.PersonFIO
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(PersonBindingModel model)
        {
            Person element = context.Persons.FirstOrDefault(rec => rec.PersonFIO ==
           model.PersonFIO);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Persons.Add(new Person
            {
                Login = model.Login,
                Password = model.Password,
                PersonFIO = model.PersonFIO
            });
            context.SaveChanges();
        }
        public void UpdElement(PersonBindingModel model)
        {
            Person element = context.Persons.FirstOrDefault(rec => rec.PersonFIO ==
           model.PersonFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            element = context.Persons.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Login = model.Login;
            element.Password = model.Password;
            element.PersonFIO = model.PersonFIO;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Person element = context.Persons.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Persons.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
