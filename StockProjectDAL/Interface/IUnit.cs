using System.Collections.Generic;
using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;

namespace StockProjectDAL.Interface
{
    public interface IUnit
    {
        List<UnitViewModel> GetList();

        UnitViewModel GetElement(int id);

        void AddElement(UnitBindingModel model);

        void UpdElement(UnitBindingModel model);

        void DelElement(int id);
    }
}
