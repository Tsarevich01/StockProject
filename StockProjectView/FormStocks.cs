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

        public FormStocks()
        {
            InitializeComponent();
        }

        private void LoadData()
        {

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPutOfStock>();
            form.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

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

        }
    }
}
