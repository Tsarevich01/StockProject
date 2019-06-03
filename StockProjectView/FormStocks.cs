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
    public partial class FormStocks : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStock service;

        public FormStocks(IStock service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void LoadData()
        {
            List<StockViewModel> list = service.GetList();
            if(list != null)
            {
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPutOfStock>();
            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        service.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormPutOfStock>();
                form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormContractors>();
            form.ShowDialog();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStatistics>();
            form.ShowDialog();
        }

        private void поступлениеНаСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPutOfStock>();
            form.ShowDialog();
        }

        private void реализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSelling>();
            form.ShowDialog();
        }

        private void списаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRemoveProduct>();
            form.ShowDialog();
        }

        private void группыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProducts>();
            form.ShowDialog();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormComponents>();
            form.ShowDialog();
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormUnits>();
            form.ShowDialog();
        }

        private void FormStocks_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
