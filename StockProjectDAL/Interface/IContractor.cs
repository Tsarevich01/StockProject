using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.Interface
{
    public interface IContractor
    {
        List<ContractorViewModel> GetList();

        ContractorViewModel GetElement(int id);

        void AddElement(ContractorBindingModel model);

        void UpdElement(ContractorBindingModel model);

        void DelElement(int id);
    }
}
