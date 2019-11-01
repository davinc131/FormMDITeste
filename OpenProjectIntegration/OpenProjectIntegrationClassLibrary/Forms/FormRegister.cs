using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProjectIntegrationClassLibrary.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            btnCancelar.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnView1.FlatAppearance.BorderSize = 0;
            btnView2.FlatAppearance.BorderSize = 0;
            btnQuery.FlatAppearance.BorderSize = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                FormPlayer formPlayer = new FormPlayer();
                formPlayer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtSenha.UseSystemPasswordChar == true)
                {
                    txtSenha.UseSystemPasswordChar = false;
                    txtSenha.PasswordChar = new Char();
                }
                else
                {
                    txtSenha.UseSystemPasswordChar = true;
                    txtSenha.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtToken.UseSystemPasswordChar == true)
                {
                    txtToken.UseSystemPasswordChar = false;
                    txtToken.PasswordChar = new Char();
                }
                else
                {
                    txtToken.UseSystemPasswordChar = true;
                    txtToken.PasswordChar = '*';
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
