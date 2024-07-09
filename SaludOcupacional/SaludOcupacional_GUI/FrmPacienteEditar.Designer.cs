namespace SaludOcupacional_GUI
{
    partial class FrmPacienteEditar
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
            txtCodigo = new TextBox();
            label2 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            label7 = new Label();
            cboDistrito = new ComboBox();
            label8 = new Label();
            txtNumeroDeHistoria = new TextBox();
            label9 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            chkActivo = new CheckBox();
            fFoto = new OpenFileDialog();
            pbFoto = new PictureBox();
            btnFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.InactiveCaption;
            txtCodigo.Enabled = false;
            txtCodigo.ForeColor = SystemColors.InactiveCaptionText;
            txtCodigo.Location = new Point(142, 32);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(142, 75);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(114, 27);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 117);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido Paterno";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(142, 117);
            txtApellidoPaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(231, 27);
            txtApellidoPaterno.TabIndex = 5;
            txtApellidoPaterno.KeyPress += txtApellidoPaterno_KeyPress;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(142, 156);
            txtApellidoMaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(231, 27);
            txtApellidoMaterno.TabIndex = 7;
            txtApellidoMaterno.KeyPress += txtApellidoMaterno_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 156);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 196);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 27);
            txtNombre.TabIndex = 9;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 196);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 235);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 10;
            label6.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(142, 235);
            cboDepartamento.Margin = new Padding(3, 4, 3, 4);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(231, 28);
            cboDepartamento.TabIndex = 11;
            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(142, 273);
            cboProvincia.Margin = new Padding(3, 4, 3, 4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(231, 28);
            cboProvincia.TabIndex = 13;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 273);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 12;
            label7.Text = "Provincia";
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(142, 312);
            cboDistrito.Margin = new Padding(3, 4, 3, 4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(231, 28);
            cboDistrito.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 312);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 14;
            label8.Text = "Distrito";
            // 
            // txtNumeroDeHistoria
            // 
            txtNumeroDeHistoria.Location = new Point(142, 351);
            txtNumeroDeHistoria.Margin = new Padding(3, 4, 3, 4);
            txtNumeroDeHistoria.Name = "txtNumeroDeHistoria";
            txtNumeroDeHistoria.Size = new Size(231, 27);
            txtNumeroDeHistoria.TabIndex = 17;
            txtNumeroDeHistoria.KeyPress += txtNumeroDeHistoria_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 351);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 16;
            label9.Text = "Nro. Historia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(186, 630);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 630);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(142, 404);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 20;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(142, 447);
            pbFoto.Margin = new Padding(3, 4, 3, 4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(231, 147);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 21;
            pbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(14, 447);
            btnFoto.Margin = new Padding(3, 4, 3, 4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(120, 31);
            btnFoto.TabIndex = 22;
            btnFoto.Text = "Agregar foto...";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // FrmPacienteEditar
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(422, 669);
            Controls.Add(btnFoto);
            Controls.Add(pbFoto);
            Controls.Add(chkActivo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumeroDeHistoria);
            Controls.Add(label9);
            Controls.Add(cboDistrito);
            Controls.Add(label8);
            Controls.Add(cboProvincia);
            Controls.Add(label7);
            Controls.Add(cboDepartamento);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(label4);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPacienteEditar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmPacienteEditar";
            Load += FrmPacienteEditar_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private Label label6;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private Label label7;
        private ComboBox cboDistrito;
        private Label label8;
        private TextBox txtNumeroDeHistoria;
        private Label label9;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox chkActivo;
        private OpenFileDialog fFoto;
        private PictureBox pbFoto;
        private Button btnFoto;
    }
}
