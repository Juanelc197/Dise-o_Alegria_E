namespace WindowsFormsApplication1
{
    partial class frmFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblConfpass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtConfpass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(157, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(157, 159);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(61, 13);
            this.lblCont.TabIndex = 2;
            this.lblCont.Text = "Contraseña";
            // 
            // lblConfpass
            // 
            this.lblConfpass.AutoSize = true;
            this.lblConfpass.Location = new System.Drawing.Point(157, 196);
            this.lblConfpass.Name = "lblConfpass";
            this.lblConfpass.Size = new System.Drawing.Size(109, 13);
            this.lblConfpass.TabIndex = 3;
            this.lblConfpass.Text = "Confirmar Contraceña";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(157, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(157, 265);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(29, 13);
            this.lblCurp.TabIndex = 5;
            this.lblCurp.Text = "Curp";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(303, 117);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 8;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(303, 152);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(100, 20);
            this.txtCont.TabIndex = 9;
            // 
            // txtConfpass
            // 
            this.txtConfpass.Location = new System.Drawing.Point(303, 189);
            this.txtConfpass.Name = "txtConfpass";
            this.txtConfpass.Size = new System.Drawing.Size(100, 20);
            this.txtConfpass.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(303, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(303, 258);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(100, 20);
            this.txtCurp.TabIndex = 12;
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfpass);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblConfpass);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormulario";
            this.Text = "Alegria en Botellada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblConfpass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtConfpass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCurp;
    }
}

