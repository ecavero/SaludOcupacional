namespace SaludOcupacional_GUI
{
    partial class FrmEmpleado
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
            dgEmpleado = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            apellidoPaterno = new DataGridViewTextBoxColumn();
            apellidoMaterno = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            provincia = new DataGridViewTextBoxColumn();
            distrito = new DataGridViewTextBoxColumn();
            nombreEmpleado = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnModificar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgEmpleado).BeginInit();
            SuspendLayout();
            // 
            // dgEmpleado
            // 
            dgEmpleado.AllowUserToAddRows = false;
            dgEmpleado.AllowUserToDeleteRows = false;
            dgEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleado.Columns.AddRange(new DataGridViewColumn[] { dni, apellidoPaterno, apellidoMaterno, nombre, departamento, provincia, distrito, nombreEmpleado, clave, estado });
            dgEmpleado.Location = new Point(43, 76);
            dgEmpleado.Margin = new Padding(3, 4, 3, 4);
            dgEmpleado.Name = "dgEmpleado";
            dgEmpleado.ReadOnly = true;
            dgEmpleado.RowHeadersVisible = false;
            dgEmpleado.RowHeadersWidth = 51;
            dgEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmpleado.Size = new Size(824, 408);
            dgEmpleado.TabIndex = 0;
            dgEmpleado.CellContentClick += dgEmpleado_CellContentClick;
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
            // nombreEmpleado
            // 
            nombreEmpleado.DataPropertyName = "nombreEmpleado";
            nombreEmpleado.HeaderText = "Usuario";
            nombreEmpleado.MinimumWidth = 6;
            nombreEmpleado.Name = "nombreEmpleado";
            nombreEmpleado.ReadOnly = true;
            // 
            // clave
            // 
            clave.DataPropertyName = "clave";
            clave.HeaderText = "Contraseña";
            clave.MinimumWidth = 6;
            clave.Name = "clave";
            clave.ReadOnly = true;
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
            btnAgregar.Location = new Point(42, 523);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(160, 523);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 31);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese Filtro:";
            label1.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(160, 25);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(397, 27);
            txtFiltro.TabIndex = 4;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(771, 525);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 29);
            lblRegistros.TabIndex = 5;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(681, 525);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Registros:";
            // 
            // FrmEmpleado
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
            Controls.Add(dgEmpleado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += FrmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEmpleado;
        private Button btnAgregar;
        private Button btnModificar;
        private Label label1;
        private TextBox txtFiltro;
        private DataGridViewTextBoxColumn idPersona;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn apellidoParterno;
        private DataGridViewTextBoxColumn apellidoMaterno;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn departamento;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn distrito;
        private DataGridViewTextBoxColumn nombreEmpleado;
        private DataGridViewTextBoxColumn clave;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn apellidoPaterno;
        private Label lblRegistros;
        private Label label2;
    }
}
