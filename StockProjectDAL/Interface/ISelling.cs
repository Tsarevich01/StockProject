using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.Interface
{
    public interface ISelling
    {
        List<SellingViewModel> GetList();

        SellingViewModel GetElement(int id);

        void AddElement(SellingBindingModel model);

        void UpdElement(SellingBindingModel model);

        void DelElement(int id);
    }
}
