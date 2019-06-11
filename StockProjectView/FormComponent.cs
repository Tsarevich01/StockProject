using System;
using System.Windows.Forms;
using StockProjectDAL.BindingModel;
using StockProjectDAL.ViewModel;
using Unity;

namespace StockProjectView
{
    public partial class FormComponent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly StockProjectDAL.Interface.IComponent service;

        public int Id { set { id = value; } }

        private int? id;

        public FormComponent(StockProjectDAL.Interface.IComponent service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormComponent_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ComponentViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxComponentName.Text = view.Name;
                        textBoxBarcode.Text = view.Barcode.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxComponentName.Text))
            {
                MessageBox.Show("Заполните наименование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxBarcode.Text))
            {
                MessageBox.Show("Заполните штрихкод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new ComponentBindingModel
                    {
                        Id = id.Value,
                        ComponentName = textBoxComponentName.Text,
                        Barcode = Convert.ToInt32(textBoxBarcode.Text)
                    });
                }
                else
                {
                    service.AddElement(new ComponentBindingModel
                    {
                        ComponentName = textBoxComponentName.Text,
                        Barcode = Convert.ToInt32(textBoxBarcode.Text)
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
    }
}
