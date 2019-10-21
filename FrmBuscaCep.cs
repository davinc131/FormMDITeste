using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSCorreios;

namespace FormMDITeste
{
    public partial class FrmBuscaCep : Form
    {
        private ServiceCorreios serviceCorreios;
        public FrmBuscaCep()
        {
            InitializeComponent();
            serviceCorreios = new ServiceCorreios();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCep.Text) || !string.IsNullOrWhiteSpace(txtCep.Text))
                {
                    var endereco = serviceCorreios.BuscarEndereco(txtCep.Text.Trim());

                    txtEstado.Text = endereco.uf;
                    txtCidade.Text = endereco.cidade;
                    txtBairro.Text = endereco.bairro;
                    txtRua.Text = endereco.end;
                }
                else
                {
                    MessageBox.Show("Informe um Cep válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCep.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtEstado.Text = string.Empty;
                txtRua.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
