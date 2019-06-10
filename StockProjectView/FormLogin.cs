using StockProjectDAL.Interface;
using System;
using System.Windows.Forms;
using Unity;

namespace StockProjectView
{
    public partial class FormLogin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IPerson service;


        public FormLogin(IPerson service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void labelRegr_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            
                var form = Container.Resolve<FormStocks>();
                form.ShowDialog();
            
            
        }
    }
}
