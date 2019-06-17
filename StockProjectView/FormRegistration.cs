using StockData;
using StockProject;
using System;
using System.Windows.Forms;

namespace StockProjectView
{
    public partial class FormRegistration : Form
    {

        public FormRegistration()
        {
            InitializeComponent();
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
            else
            {
                using (var context = new StockDataContext()) 
                {
                    context.Users.Add(new User
                    {
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        FIO = textBoxFIO.Text
                    });
                    context.SaveChanges();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
