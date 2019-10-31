using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPlayer;

namespace OpenProjectIntegrationClassLibrary.Forms
{
    public partial class FormPlayer : Form
    {
        VideoPlayer player = new VideoPlayer();

        public FormPlayer()
        {
            InitializeComponent();

            this.Controls.Add(player);

            player.MediaUri = new Uri(@"Resources/Create_Token.wmv");
            player.Play();
        }
    }
}
