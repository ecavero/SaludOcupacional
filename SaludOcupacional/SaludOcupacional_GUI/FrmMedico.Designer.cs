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
            ((System.ComponentModel.ISupportInitialize)dgMedicos).BeginInit();
            SuspendLayout();
            // 
            // dgMedicos
            // 
            dgMedicos.AllowUserToAddRows = false;
            dgMedicos.AllowUserToDeleteRows = false;
            dgMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedicos.Location = new Point(10, 46);
            dgMedicos.Name = "dgMedicos";
            dgMedicos.ReadOnly = true;
            dgMedicos.RowHeadersVisible = false;
            dgMedicos.RowHeadersWidth = 51;
            dgMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMedicos.Size = new Size(751, 317);
            dgMedicos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(10, 387);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(101, 387);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(114, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(348, 23);
            txtFiltro.TabIndex = 6;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 5;
            label1.Text = "Ingrese Filtro:";
            // 
            // FrmMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 428);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgMedicos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMedico";
            Text = "FrmMedico";
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
    }
}