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
    public partial class FormPutOfStock : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IStock service;

        private List<StockComponentViewModel> stockcomponent;

        private int? id;

        public FormPutOfStock(IStock service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonStamp_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendToEmail_Click(object sender, EventArgs e)
        {

        }

        private void FormPutOfStock_Load(object sender, EventArgs e)
        {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
