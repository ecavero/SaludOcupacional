﻿namespace SaludOcupacional_GUI
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.InactiveCaption;
            txtCodigo.Enabled = false;
            txtCodigo.ForeColor = SystemColors.InactiveCaptionText;
            txtCodigo.Location = new Point(124, 24);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(124, 56);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido Paterno";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(124, 88);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(203, 23);
            txtApellidoPaterno.TabIndex = 5;
            txtApellidoPaterno.KeyPress += txtApellidoPaterno_KeyPress;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(124, 117);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(203, 23);
            txtApellidoMaterno.TabIndex = 7;
            txtApellidoMaterno.KeyPress += txtApellidoMaterno_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 23);
            txtNombre.TabIndex = 9;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 176);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 10;
            label6.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(124, 176);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(203, 23);
            cboDepartamento.TabIndex = 11;
            cboDepartamento.SelectedIndexChanged += cboDepartamento_SelectedIndexChanged;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(124, 205);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(203, 23);
            cboProvincia.TabIndex = 13;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 205);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 12;
            label7.Text = "Provincia";
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(124, 234);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(203, 23);
            cboDistrito.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 234);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "Distrito";
            // 
            // txtNumeroDeHistoria
            // 
            txtNumeroDeHistoria.Location = new Point(124, 263);
            txtNumeroDeHistoria.Name = "txtNumeroDeHistoria";
            txtNumeroDeHistoria.Size = new Size(203, 23);
            txtNumeroDeHistoria.TabIndex = 17;
            txtNumeroDeHistoria.KeyPress += txtNumeroDeHistoria_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 263);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 16;
            label9.Text = "Nro. Historia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(171, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(124, 303);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 20;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // FrmPacienteEditar
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(369, 450);
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
            Name = "FrmPacienteEditar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmPacienteEditar";
            Load += FrmPacienteEditar_Load;
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
    }
}
