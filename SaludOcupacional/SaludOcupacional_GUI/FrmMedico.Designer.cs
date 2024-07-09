namespace SaludOcupacional_View
{
    partial class FrmMedico
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
            dgMedicos = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            lblRegistros = new Label();
            label2 = new Label();
            id_Persona = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            apellidoPaterno = new DataGridViewTextBoxColumn();
            apellidoMaterno = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            provincia = new DataGridViewTextBoxColumn();
            distrito = new DataGridViewTextBoxColumn();
            nroColegiatura = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgMedicos).BeginInit();
            SuspendLayout();
            // 
            // dgMedicos
            // 
            dgMedicos.AllowUserToAddRows = false;
            dgMedicos.AllowUserToDeleteRows = false;
            dgMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedicos.Columns.AddRange(new DataGridViewColumn[] { id_Persona, dni, apellidoPaterno, apellidoMaterno, nombre, departamento, provincia, distrito, nroColegiatura, especialidad, estado });
            dgMedicos.Location = new Point(11, 61);
            dgMedicos.Margin = new Padding(3, 4, 3, 4);
            dgMedicos.Name = "dgMedicos";
            dgMedicos.ReadOnly = true;
            dgMedicos.RowHeadersVisible = false;
            dgMedicos.RowHeadersWidth = 51;
            dgMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMedicos.Size = new Size(858, 423);
            dgMedicos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(11, 516);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(115, 516);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(130, 16);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(397, 27);
            txtFiltro.TabIndex = 6;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingrese Filtro:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(773, 518);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 29);
            lblRegistros.TabIndex = 7;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(683, 518);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "Registros:";
            // 
            // id_Persona
            // 
            id_Persona.DataPropertyName = "idPersona";
            id_Persona.HeaderText = "ID";
            id_Persona.MinimumWidth = 6;
            id_Persona.Name = "id_Persona";
            id_Persona.ReadOnly = true;
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
            // nroColegiatura
            // 
            nroColegiatura.DataPropertyName = "nroColegiatura";
            nroColegiatura.HeaderText = "N° Colegiatura";
            nroColegiatura.MinimumWidth = 6;
            nroColegiatura.Name = "nroColegiatura";
            nroColegiatura.ReadOnly = true;
            // 
            // especialidad
            // 
            especialidad.DataPropertyName = "especialidad";
            especialidad.HeaderText = "Especialidad";
            especialidad.MinimumWidth = 6;
            especialidad.Name = "especialidad";
            especialidad.ReadOnly = true;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // FrmMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgMedicos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Médicos";
            Load += FrmMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dgMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMedicos;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtFiltro;
        private Label label1;
        private Label lblRegistros;
        private Label label2;
        private DataGridViewTextBoxColumn id_Persona;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn apellidoPaterno;
        private DataGridViewTextBoxColumn apellidoMaterno;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn departamento;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn distrito;
        private DataGridViewTextBoxColumn nroColegiatura;
        private DataGridViewTextBoxColumn especialidad;
        private DataGridViewTextBoxColumn estado;
    }
}