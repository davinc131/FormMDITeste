namespace OpenProjectIntegrationClassLibrary.Forms
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnView1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnView2 = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Token:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(183, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Register";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(75, 98);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(363, 20);
            this.txtLogin.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(76, 156);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(362, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(76, 207);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '*';
            this.txtToken.Size = new System.Drawing.Size(362, 20);
            this.txtToken.TabIndex = 7;
            this.txtToken.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.Location = new System.Drawing.Point(143, 265);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Gravar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.Location = new System.Drawing.Point(224, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnView1
            // 
            this.btnView1.BackgroundImage = global::OpenProjectIntegrationClassLibrary.Properties.Resources._35581;
            this.btnView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnView1.Location = new System.Drawing.Point(444, 153);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(49, 23);
            this.btnView1.TabIndex = 10;
            this.btnView1.UseVisualStyleBackColor = true;
            this.btnView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnView1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenProjectIntegrationClassLibrary.Properties.Resources._149071;
            this.pictureBox1.Location = new System.Drawing.Point(183, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnView2
            // 
            this.btnView2.BackgroundImage = global::OpenProjectIntegrationClassLibrary.Properties.Resources._35581;
            this.btnView2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnView2.Location = new System.Drawing.Point(444, 207);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(49, 23);
            this.btnView2.TabIndex = 11;
            this.btnView2.UseVisualStyleBackColor = true;
            this.btnView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnView2_MouseClick);
            // 
            // btnQuery
            // 
            this.btnQuery.BackgroundImage = global::OpenProjectIntegrationClassLibrary.Properties.Resources._36601;
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnQuery.Location = new System.Drawing.Point(444, 236);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnView2);
            this.Controls.Add(this.btnView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnView1;
        private System.Windows.Forms.Button btnView2;
        private System.Windows.Forms.Button btnQuery;
    }
}