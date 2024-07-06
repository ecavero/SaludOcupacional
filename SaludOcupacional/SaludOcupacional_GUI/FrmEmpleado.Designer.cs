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
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgEmpleado);
            Margin = new Padding(3, 4, 3, 4);
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
