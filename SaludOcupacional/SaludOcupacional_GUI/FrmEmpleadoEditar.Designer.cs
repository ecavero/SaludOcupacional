namespace SaludOcupacional_GUI
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
            pbFoto = new PictureBox();
            btnFoto = new Button();
            fFoto = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 103);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 209);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 264);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre Empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 321);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 5;
            label6.Text = "Departamento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 383);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 441);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 7;
            label8.Text = "Distrito";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 503);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 8;
            label9.Text = "Nombre de Usuario";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.InactiveCaption;
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(211, 49);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(211, 103);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(114, 27);
            txtDni.TabIndex = 1;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(211, 156);
            txtApellidoPaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(172, 27);
            txtApellidoPaterno.TabIndex = 2;
            txtApellidoPaterno.KeyPress += txtApellidoPaterno_KeyPress;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(211, 209);
            txtApellidoMaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(172, 27);
            txtApellidoMaterno.TabIndex = 3;
            txtApellidoMaterno.KeyPress += txtApellidoMaterno_KeyPress;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(211, 321);
            cboDepartamento.Margin = new Padding(3, 4, 3, 4);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(172, 28);
            cboDepartamento.TabIndex = 5;
            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(211, 383);
            cboProvincia.Margin = new Padding(3, 4, 3, 4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(172, 28);
            cboProvincia.TabIndex = 6;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(211, 441);
            cboDistrito.Margin = new Padding(3, 4, 3, 4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(172, 28);
            cboDistrito.TabIndex = 7;
            cboDistrito.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(211, 503);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(172, 27);
            txtUsuario.TabIndex = 8;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(211, 264);
            txtNombreEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(172, 27);
            txtNombreEmpleado.TabIndex = 4;
            txtNombreEmpleado.KeyPress += txtNombreEmpleado_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(211, 849);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(324, 849);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(211, 559);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(172, 27);
            txtClave.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 559);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 12;
            label10.Text = "Clave";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(211, 612);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 21;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(211, 659);
            pbFoto.Margin = new Padding(3, 4, 3, 4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(172, 147);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 22;
            pbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(23, 659);
            btnFoto.Margin = new Padding(3, 4, 3, 4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(127, 31);
            btnFoto.TabIndex = 35;
            btnFoto.Text = "AgregarFoto...";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // fFoto
            // 
            fFoto.FileName = "openFileDialog1";
            // 
            // FrmEmpleadoEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 892);
            Controls.Add(btnFoto);
            Controls.Add(pbFoto);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmpleadoEditar";
            Text = "FrmEmpleadoEditar";
            Load += FrmEmpleadoEditar_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
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
        private PictureBox pbFoto;
        private Button btnFoto;
        private OpenFileDialog fFoto;
    }
}
