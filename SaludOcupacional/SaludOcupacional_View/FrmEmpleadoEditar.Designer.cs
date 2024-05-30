namespace SaludOcupacional_View
{
    partial class FrmEmpleadoEditar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCodigo = new TextBox();
            txtDni = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            txtUsuario = new TextBox();
            txtNombreEmpleado = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtClave = new TextBox();
            label10 = new Label();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 117);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 157);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 198);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre Empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 241);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 5;
            label6.Text = "Departamento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 287);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 331);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 7;
            label8.Text = "Distrito";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 377);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 8;
            label9.Text = "Nombre de Usuario";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.InactiveCaption;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(185, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(185, 77);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 1;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(185, 117);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(151, 23);
            txtApellidoPaterno.TabIndex = 2;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(185, 157);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(151, 23);
            txtApellidoMaterno.TabIndex = 3;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(185, 241);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(151, 23);
            cboDepartamento.TabIndex = 5;
            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(185, 287);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(151, 23);
            cboProvincia.TabIndex = 6;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(185, 331);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(151, 23);
            cboDistrito.TabIndex = 7;
            cboDistrito.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(185, 377);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(151, 23);
            txtUsuario.TabIndex = 8;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(185, 198);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(151, 23);
            txtNombreEmpleado.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(170, 484);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(281, 484);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(185, 419);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(151, 23);
            txtClave.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 419);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 12;
            label10.Text = "Clave";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(185, 459);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 21;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleadoEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 541);
            Controls.Add(chkActivo);
            Controls.Add(txtClave);
            Controls.Add(label10);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(txtUsuario);
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
            Name = "FrmEmpleadoEditar";
            Text = "FrmEmpleadoEditar";
            Load += FrmEmpleadoEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCodigo;
        private TextBox txtDni;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private TextBox txtUsuario;
        private TextBox txtNombreEmpleado;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtClave;
        private Label label10;
        private CheckBox chkActivo;
    }
}