using StockProjectDAL.Interface;
using StockProjectDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using IComponent = StockProjectDAL.Interface.IComponent;

namespace StockProjectView
{
    public partial class FormStock : Form
    {
        [Dependency]

        private readonly IStock serviceS;
        private readonly IProduct serviceP;

        private readonly IComponent service;

        public FormStock(IComponent service, IStock serviceS, IProduct serviceP)
        {
            InitializeComponent();
            this.service = service;
            this.serviceS = serviceS;
            this.serviceP = serviceP;

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            try
            {
                List<ComponentViewModel> list = service.GetList();
                if (list != null)
                {
                    comboBoxName.DisplayMember = "Name";
                    comboBoxName.ValueMember = "Id";
                    comboBoxName.DataSource = list;
                    comboBoxName.SelectedItem = null;
                    comboBoxBarcode.DisplayMember = "Barcode";
                    comboBoxBarcode.ValueMember = "Id";
                    comboBoxBarcode.DataSource = list;
                    comboBoxBarcode.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void CalcSum()
        {
            if (comboBoxName.SelectedValue != null && !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int count = Convert.ToInt32(textBoxCount.Text);
                    int id = Convert.ToInt32(comboBoxName.SelectedValue);
                    ProductViewModel product = serviceP.GetElement(id);
                    textBoxSum.Text = (count * product.Price).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
