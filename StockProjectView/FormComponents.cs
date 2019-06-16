using System.ComponentModel;
using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using System.Windows.Forms;
using Unity;
using System.Collections.Generic;
using System;

namespace StockProjectView
{
    public partial class FormComponents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly StockProjectDAL.Interface.IComponent service;

        public FormComponents(StockProjectDAL.Interface.IComponent service)
        {
            InitializeComponent();
            this.service = service;
        }

        public void LoadData()
        {
            try
            {
                List<ComponentViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormComponents_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormComponent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDel_Click(object sender, System.EventArgs e)
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

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormComponent>();
                form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonReady_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
