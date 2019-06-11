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
    public class PersonServiceDB : IPerson
    {
        private StockDataContext context;
        public PersonServiceDB(StockDataContext context)
        {
            this.context = context;
        }
        public List<PersonViewModel> GetList()
        {
            List<PersonViewModel> result = context.Users.Select(rec => new
           PersonViewModel
            {
                Id = rec.Id,
                Login = rec.Login,
                Password = rec.Password,
                PersonFIO = rec.FIO
            })
            .ToList();
            return result;
        }
        public PersonViewModel GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new PersonViewModel
                {
                    Id = element.Id,
                    Login = element.Login,
                    Password = element.Password,
                    PersonFIO = element.FIO
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(PersonBindingModel model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.FIO ==
           model.PersonFIO);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Users.Add(new User
            {
                Login = model.Login,
                Password = model.Password,
                FIO = model.PersonFIO
            });
            context.SaveChanges();
        }
        public void UpdElement(PersonBindingModel model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.FIO ==
           model.PersonFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Login = model.Login;
            element.Password = model.Password;
            element.FIO = model.PersonFIO;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Users.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
