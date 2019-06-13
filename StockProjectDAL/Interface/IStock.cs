using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;

namespace StockProjectDAL.Interface
{
    public interface IStock
    {
        List<StockViewModel> GetList();

        StockViewModel GetElement(int id);

        void DelElement(int id);
        void Stock(StockBindingModel stockBindingModel);
        void Stock(StockComponentBindingModel stockComponentBindingModel);
    }
}
