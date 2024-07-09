namespace SaludOcupacional_GUI
{
    partial class frmPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPacientes = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            apellidoPaterno = new DataGridViewTextBoxColumn();
            apellidoMaterno = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            provincia = new DataGridViewTextBoxColumn();
            distrito = new DataGridViewTextBoxColumn();
            numeroDeHistoria = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgPacientes
            // 
            dgPacientes.AllowUserToAddRows = false;
            dgPacientes.AllowUserToDeleteRows = false;
            dgPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPacientes.Columns.AddRange(new DataGridViewColumn[] { dni, apellidoPaterno, apellidoMaterno, nombre, departamento, provincia, distrito, numeroDeHistoria, estado });
            dgPacientes.Location = new Point(38, 81);
            dgPacientes.Margin = new Padding(3, 4, 3, 4);
            dgPacientes.Name = "dgPacientes";
            dgPacientes.ReadOnly = true;
            dgPacientes.RowHeadersVisible = false;
            dgPacientes.RowHeadersWidth = 51;
            dgPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPacientes.Size = new Size(851, 423);
            dgPacientes.TabIndex = 0;
            // 
            // dni
            // 
            dni.DataPropertyName = "dni";
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // apellidoPaterno
            // 
            apellidoPaterno.DataPropertyName = "apellidoPaterno";
            apellidoPaterno.HeaderText = "Ap. Paterno";
            apellidoPaterno.MinimumWidth = 6;
            apellidoPaterno.Name = "apellidoPaterno";
            apellidoPaterno.ReadOnly = true;
            // 
            // apellidoMaterno
            // 
            apellidoMaterno.DataPropertyName = "apellidoMaterno";
            apellidoMaterno.HeaderText = "Ap. Materno";
            apellidoMaterno.MinimumWidth = 6;
            apellidoMaterno.Name = "apellidoMaterno";
            apellidoMaterno.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // departamento
            // 
            departamento.DataPropertyName = "departamento";
            departamento.HeaderText = "Departamento";
            departamento.MinimumWidth = 6;
            departamento.Name = "departamento";
            departamento.ReadOnly = true;
            // 
            // provincia
            // 
            provincia.DataPropertyName = "provincia";
            provincia.HeaderText = "Provincia";
            provincia.MinimumWidth = 6;
            provincia.Name = "provincia";
            provincia.ReadOnly = true;
            // 
            // distrito
            // 
            distrito.DataPropertyName = "distrito";
            distrito.HeaderText = "Distrito";
            distrito.MinimumWidth = 6;
            distrito.Name = "distrito";
            distrito.ReadOnly = true;
            // 
            // numeroDeHistoria
            // 
            numeroDeHistoria.DataPropertyName = "numeroDeHistoria";
            numeroDeHistoria.HeaderText = "N° Historia";
            numeroDeHistoria.MinimumWidth = 6;
            numeroDeHistoria.Name = "numeroDeHistoria";
            numeroDeHistoria.ReadOnly = true;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(38, 536);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(144, 536);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(158, 28);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(397, 27);
            txtFiltro.TabIndex = 8;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Ingrese Filtro:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(793, 538);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 29);
            lblRegistros.TabIndex = 9;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 538);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "Registros:";
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgPacientes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPacientes;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtFiltro;
        private Label label1;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn apellidoPaterno;
        private DataGridViewTextBoxColumn apellidoMaterno;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn departamento;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn distrito;
        private DataGridViewTextBoxColumn numeroDeHistoria;
        private DataGridViewTextBoxColumn estado;
        private Label lblRegistros;
        private Label label2;
    }
}
