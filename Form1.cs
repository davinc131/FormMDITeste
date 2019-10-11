﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMDITeste._01_SerializarXml;

namespace FormMDITeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SerializarXml serializarXml = new SerializarXml();

            MessageBox.Show(string.Format("Usuário(Nome): {0},\n CPF: {1},\n Email: {2}", serializarXml.Deserializer().Nome, serializarXml.Deserializer().CPF, serializarXml.Deserializer().Email));
        }

        private void Form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm2 = new Form2();
                frm2.MdiParent = this;
                frm2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm3 = new Form3();
                frm3.MdiParent = this;
                frm3.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    if (control is MdiClient)
                    {
                        ModalForm modalForm = new ModalForm();
                        modalForm.ShowDialog();

                        //control.BackColor = Color.Aquamarine;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
