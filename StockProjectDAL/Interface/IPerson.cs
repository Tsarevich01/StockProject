using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.Interface
{
    public interface IPerson
    {
        List<PersonViewModel> GetList();

        PersonViewModel GetElement(int id);

        void AddElement(PersonBindingModel model);

        void UpdElement(PersonBindingModel model);

        void DelElement(int id);
    }
}
