using StockData;
using StockDB.Implementations;
using StockProjectDAL.Interface;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace StockProjectView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;
            using (var loginForm = new FormLogin())
                result = loginForm.ShowDialog();
            if(result == DialogResult.OK)
                Application.Run(container.Resolve<FormStocks>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<DbContext, StockDataContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPerson, PersonServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProduct, ProductServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IComponent, ComponentServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IContractor, ContractorServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUnit, UnitServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStock, StockServiceDB>(new
           HierarchicalLifetimeManager());


            return currentContainer;
        }
    }
}
