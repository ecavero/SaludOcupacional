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
            btnAgregar = new Button();
            btnModificar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgEmpleado).BeginInit();
            SuspendLayout();
            // 
            // dgEmpleado
            // 
            dgEmpleado.AllowUserToAddRows = false;
            dgEmpleado.AllowUserToDeleteRows = false;
            dgEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleado.Location = new Point(38, 57);
            dgEmpleado.Name = "dgEmpleado";
            dgEmpleado.ReadOnly = true;
            dgEmpleado.RowHeadersVisible = false;
            dgEmpleado.RowHeadersWidth = 51;
            dgEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmpleado.Size = new Size(721, 306);
            dgEmpleado.TabIndex = 0;
            dgEmpleado.CellContentClick += dgEmpleado_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 392);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(140, 392);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese Filtro:";
            label1.Click += label1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(140, 19);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(348, 23);
            txtFiltro.TabIndex = 4;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgEmpleado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FrmEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmpleado";
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
    }
}
