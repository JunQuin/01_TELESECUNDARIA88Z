﻿namespace _01_TELESECUNDARIA88Z.formas
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pboxUser = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(315, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(315, 69);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(324, 307);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(82, 17);
            this.lblCargando.TabIndex = 4;
            this.lblCargando.Text = "Cargando...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(131, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel";
            // 
            // txtNivel
            // 
            this.txtNivel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNivel.Enabled = false;
            this.txtNivel.Location = new System.Drawing.Point(89, 33);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(123, 22);
            this.txtNivel.TabIndex = 6;
            this.txtNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(315, 223);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(100, 41);
            this.btningresar.TabIndex = 7;
            this.btningresar.Text = "INGRESAR";
            this.toolTip1.SetToolTip(this.btningresar, "INGRESAR");
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            this.btningresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btningresar_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::_01_TELESECUNDARIA88Z.Properties.Resources.Exit_png_32x32;
            this.btnSalir.Location = new System.Drawing.Point(92, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 61);
            this.btnSalir.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSalir, "SALIR");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pboxUser
            // 
            this.pboxUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxUser.Image = global::_01_TELESECUNDARIA88Z.Properties.Resources.usuario;
            this.pboxUser.Location = new System.Drawing.Point(53, 85);
            this.pboxUser.Name = "pboxUser";
            this.pboxUser.Size = new System.Drawing.Size(180, 180);
            this.pboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxUser.TabIndex = 0;
            this.pboxUser.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(102, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ultimo Acceso";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDateTime.Enabled = false;
            this.txtDateTime.Location = new System.Drawing.Point(7, 171);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.Size = new System.Drawing.Size(287, 22);
            this.txtDateTime.TabIndex = 13;
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNivel);
            this.groupBox1.Controls.Add(this.txtDateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(440, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 340);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pboxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESSION";
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}