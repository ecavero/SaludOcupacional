namespace SaludOcupacional_View
{
    partial class FrmEmpleadoModificar
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtNombreEmpleado = new TextBox();
            txtClave = new TextBox();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtDni = new TextBox();
            txtCodigo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 466);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(181, 466);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 38;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(195, 180);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(151, 23);
            txtNombreEmpleado.TabIndex = 37;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(195, 359);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(151, 23);
            txtClave.TabIndex = 36;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(195, 313);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(151, 23);
            cboDistrito.TabIndex = 35;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(195, 269);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(151, 23);
            cboProvincia.TabIndex = 34;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(195, 223);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(151, 23);
            cboDepartamento.TabIndex = 33;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(195, 139);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(151, 23);
            txtApellidoMaterno.TabIndex = 32;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(195, 99);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(151, 23);
            txtApellidoPaterno.TabIndex = 31;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(195, 59);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 30;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.InactiveCaption;
            txtCodigo.Location = new Point(195, 19);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 359);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 28;
            label9.Text = "Clave";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 313);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 27;
            label8.Text = "Distrito";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 269);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 26;
            label7.Text = "Provincia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 223);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 25;
            label6.Text = "Departamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 180);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 24;
            label5.Text = "Nombre Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 139);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 23;
            label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 99);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 22;
            label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 59);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 21;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 20;
            label1.Text = "Codigo";
            // 
            // FrmEmpleadoModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 513);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(txtClave);
            Controls.Add(cboDistrito);
            Controls.Add(cboProvincia);
            Controls.Add(cboDepartamento);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtDni);
            Controls.Add(txtCodigo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEmpleadoModificar";
            Text = "FrmEmpleadoModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtNombreEmpleado;
        private TextBox txtClave;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtDni;
        private TextBox txtCodigo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}