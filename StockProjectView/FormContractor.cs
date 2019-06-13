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

namespace StockProjectView
{
    public partial class FormContractor : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IContractor service;

        private int? id;

        public FormContractor(IContractor service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxComponentName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxCode.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxConact.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxLegalAdres.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new ContractorBindingModel
                    {
                        Id = id.Value,
                        ContractorName = textBoxComponentName.Text,
                        ContractorEmail = textBoxEmail.Text,
                        UrAdres = textBoxLegalAdres.Text,
                        Phone = Convert.ToInt32(textBoxConact.Text),
                        Code = Convert.ToInt32(textBoxCode.Text)
                    });
                }
                else
                {
                    service.AddElement(new ContractorBindingModel
                    {
                        ContractorName = textBoxComponentName.Text,
                        ContractorEmail = textBoxEmail.Text,
                        UrAdres = textBoxLegalAdres.Text,
                        Phone = Convert.ToInt32(textBoxConact.Text),
                        Code = Convert.ToInt32(textBoxCode.Text)
                    });
                }
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

        private void FormContractor_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ContractorViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxComponentName.Text = view.ContractorName;
                        textBoxCode.Text = view.Code.ToString();
                        textBoxConact.Text = view.Phone.ToString();
                        textBoxEmail.Text = view.ContractorEmail;
                        textBoxLegalAdres.Text = view.UrAdres;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
