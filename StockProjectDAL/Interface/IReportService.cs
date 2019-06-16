using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.Interface
{
    public interface IReportService
    {
        List<StockComponentViewModel> GetReport(ReportBindingModel model);

        void SaveReport(ReportBindingModel model);
    }
}
