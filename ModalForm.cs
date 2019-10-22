using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace FormMDITeste
{
    public partial class ModalForm : Form
    {
        private DispatcherTimer timer;

        public ModalForm()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.IsEnabled = true;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalForm_Load(object sender, EventArgs e)
        {
            try
            {
                //pictureBox1.Image = Image.FromFile(@"Resources\loader3.gif");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
