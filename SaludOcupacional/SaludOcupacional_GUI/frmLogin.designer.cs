namespace ProyWinC_Sem03
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.CharacterCasing = CharacterCasing.Upper;
            txtLogin.Location = new Point(139, 39);
            txtLogin.Margin = new Padding(5, 4, 5, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(132, 27);
            txtLogin.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 79);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.CharacterCasing = CharacterCasing.Upper;
            txtPassword.Location = new Point(139, 79);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(132, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(312, 41);
            btnAceptar.Margin = new Padding(5, 4, 5, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(102, 37);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(312, 88);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 37);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmLogin
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 167);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingrese su usuario y contraseña";
            FormClosed += frmLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
    }
}