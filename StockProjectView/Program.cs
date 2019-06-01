using StockDB;
using StockDB.Implementations;
using StockProjectDAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run(new FormLogin());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<DbContext, StockDBContext>(new
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
