using StockDB;
using StockProject;
using StockProjectDAL.Interface;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace StockProjectView
{
    public partial class FormLogin : Form
    {
        public Person person { get; private set; }

        public FormLogin()
        {
            InitializeComponent();

            person = null;
        }

        private void labelRegr_Click(object sender, EventArgs e)
        {
            var form = new FormRegistration();
            form.ShowDialog();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) && string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                SetUser();
            }
        }

        private void SetUser()
        {
            using (var context = new StockDBContext())
            {
                var user = context.Persons.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
                if (user != null)
                {
                    person = user;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
             }
        }

    }
}
