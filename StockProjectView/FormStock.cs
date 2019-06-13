using StockProjectDAL.BindingModel;
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
                List<ProductViewModel> listP = serviceP.GetList();
                if(listP != null)
                {
                    comboBoxName.DisplayMember = "Name";
                    comboBoxName.ValueMember = "Id";
                    comboBoxName.DataSource = listP;
                    comboBoxName.SelectedItem = null;
                }
                List<ComponentViewModel> list = service.GetList();
                if (list != null)
                {
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

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxName.SelectedValue == null)
            {
                MessageBox.Show("Выберите Название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxBarcode.SelectedValue == null)
            {
                MessageBox.Show("Выберите штрихкод", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                serviceS.Stock(new StockComponentBindingModel
                {
                    ProductId = Convert.ToInt32(comboBoxName.SelectedValue),
                    ComponentId = Convert.ToInt32(comboBoxBarcode.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToInt32(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void CalcSumInNDS()
        {
            if (comboBoxName.SelectedValue != null && !string.IsNullOrEmpty(textBoxSum.Text))
            {
                try
                {
                    double count = Convert.ToInt32(textBoxSum.Text);
                    textBoxSumInNDS.Text = (count * 1.2).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            CalcSumInNDS();
        }
    }
}
