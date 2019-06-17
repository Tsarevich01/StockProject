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
    public partial class FormRenamePersonalData : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IPerson service;

        public int Id { set { id = value; } }

        private int? id;
        public FormRenamePersonalData(IPerson service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введите логин и(или) пароль");
            }
            else if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Введите ФИО");
            }
            else if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }

            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new PersonBindingModel
                    {
                        Id = id.Value,
                        PersonFIO = textBoxFIO.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        
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
        private void FormRenamePersonalData_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    PersonViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxFIO.Text = view.PersonFIO;
                        textBoxLogin.Text = view.Login;
                        textBoxPassword.Text = view.Password;
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
