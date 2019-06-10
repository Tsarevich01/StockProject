using StockDB;
using StockProject;
using StockProjectDAL.BindingModel;
using StockProjectDAL.Interface;
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
                using (var context = new StockDBContext())
                {
                    var user = context.Persons.Add(new Person
                    {
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        PersonFIO = textBoxFIO.Text
                    });
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
