using OpenProjectIntegrationClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace FormMDITeste
{
    static class Program
    {
        public static UnityContainer Container { get; set; }
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container = new UnityContainer();
            DependencyRegister.Register.RegisterObjectInContainer(Container);

            Application.Run(new Form1());
        }
    }
}
