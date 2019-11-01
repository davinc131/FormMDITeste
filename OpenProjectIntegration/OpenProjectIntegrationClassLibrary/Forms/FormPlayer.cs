using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProjectIntegrationClassLibrary.Forms
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string caminho = System.AppDomain.CurrentDomain.BaseDirectory;

            var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Create_Token.wmv");

            try
            {
                // ResourceName = the resource you want to play
                File.WriteAllBytes(strTempFile, Properties.Resources.Create_Token);
                axWindowsMediaPlayer1.URL = strTempFile;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
