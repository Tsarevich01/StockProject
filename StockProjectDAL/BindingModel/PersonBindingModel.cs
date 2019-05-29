using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProjectDAL.BindingModel
{
    public class PersonBindingModel
    {
        public int Id { get; set; }
                 
        public string PersonFIO { get; set; }
                 
        public string Login { get; set; }
                 
        public string Password { get; set; }
    }
}
