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

namespace StockProjectView
{
    public partial class FormSelling : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IStock service;
        private readonly IContractor serviceC;
        private List<StockComponentViewModel> stockcomponent;

        private int? id;

        public FormSelling(IStock service, IContractor serviceC)
        {
            InitializeComponent();
            this.service = service;
            this.serviceC = serviceC;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (comboBoxContr.Text == null)
            {
                MessageBox.Show("Выберите поставщика", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonStamp_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReport>();
            form.ShowDialog();
        }

        private void buttonSendToEmail_Click(object sender, EventArgs e)
        {

        }

        private void FormPutOfStock_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                stockcomponent = new List<StockComponentViewModel>();
            }
        }
        public void LoadData()
        {
            try
            {
                if (stockcomponent != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = stockcomponent;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                }
                var list = serviceC.GetList().ToDictionary(x => x.Id, x => x.ContractorName);
                if (list != null)
                {
                    comboBoxContr.DataSource = new BindingSource(list, null);
                    comboBoxContr.DisplayMember = "Value";
                    comboBoxContr.ValueMember = "Key";
                    comboBoxContr.SelectedItem = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStock>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
