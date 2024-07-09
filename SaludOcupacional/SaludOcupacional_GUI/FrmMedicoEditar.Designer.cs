﻿namespace SaludOcupacional_GUI
{
    partial class FrmMedicoEditar
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtColegiatura = new TextBox();
            chkActivo = new CheckBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            txtEspecialidad = new TextBox();
            fFoto = new OpenFileDialog();
            btnFoto = new Button();
            pbFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 113);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 164);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 224);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 52);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 401);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 10;
            label8.Text = "Distrito";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 343);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 9;
            label7.Text = "Provincia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 281);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 8;
            label6.Text = "Departamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 464);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 11;
            label5.Text = "Numero de colegiatura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 529);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 12;
            label9.Text = "Especialidad:";
            label9.Click += label9_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 41);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 13;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(202, 109);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(114, 27);
            txtDNI.TabIndex = 14;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(202, 160);
            txtApellidoPaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(172, 27);
            txtApellidoPaterno.TabIndex = 15;
            txtApellidoPaterno.KeyPress += txtApellidoPaterno_KeyPress;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(202, 213);
            txtApellidoMaterno.Margin = new Padding(3, 4, 3, 4);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(172, 27);
            txtApellidoMaterno.TabIndex = 16;
            txtApellidoMaterno.KeyPress += txtApellidoMaterno_KeyPress;
            // 
            // txtColegiatura
            // 
            txtColegiatura.Location = new Point(202, 460);
            txtColegiatura.Margin = new Padding(3, 4, 3, 4);
            txtColegiatura.Name = "txtColegiatura";
            txtColegiatura.Size = new Size(172, 27);
            txtColegiatura.TabIndex = 20;
            txtColegiatura.KeyPress += txtColegiatura_KeyPress;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(202, 585);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 22;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(288, 824);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(165, 824);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(202, 277);
            cboDepartamento.Margin = new Padding(3, 4, 3, 4);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(172, 28);
            cboDepartamento.TabIndex = 30;
            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(202, 343);
            cboProvincia.Margin = new Padding(3, 4, 3, 4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(172, 28);
            cboProvincia.TabIndex = 31;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(202, 397);
            cboDistrito.Margin = new Padding(3, 4, 3, 4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(172, 28);
            cboDistrito.TabIndex = 32;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(202, 525);
            txtEspecialidad.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(172, 27);
            txtEspecialidad.TabIndex = 33;
            txtEspecialidad.KeyPress += txtEspecialidad_KeyPress;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(27, 641);
            btnFoto.Margin = new Padding(3, 4, 3, 4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(127, 31);
            btnFoto.TabIndex = 34;
            btnFoto.Text = "AgregarFoto...";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(202, 630);
            pbFoto.Margin = new Padding(3, 4, 3, 4);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(172, 152);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 35;
            pbFoto.TabStop = false;
            // 
            // FrmMedicoEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 870);
            Controls.Add(pbFoto);
            Controls.Add(btnFoto);
            Controls.Add(txtEspecialidad);
            Controls.Add(cboDistrito);
            Controls.Add(cboProvincia);
            Controls.Add(cboDepartamento);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(chkActivo);
            Controls.Add(txtColegiatura);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMedicoEditar";
            Text = "FrmMedicoEditar";
            Load += FrmMedicoEditar_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private TextBox txtColegiatura;
        private CheckBox chkActivo;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private TextBox txtEspecialidad;
        private OpenFileDialog fFoto;
        private Button btnFoto;
        private PictureBox pbFoto;
    }
}