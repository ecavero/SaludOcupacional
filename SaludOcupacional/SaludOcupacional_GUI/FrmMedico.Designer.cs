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
            ((System.ComponentModel.ISupportInitialize)dgMedicos).BeginInit();
            SuspendLayout();
            // 
            // dgMedicos
            // 
            dgMedicos.AllowUserToAddRows = false;
            dgMedicos.AllowUserToDeleteRows = false;
            dgMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMedicos.Location = new Point(12, 62);
            dgMedicos.Margin = new Padding(3, 4, 3, 4);
            dgMedicos.Name = "dgMedicos";
            dgMedicos.ReadOnly = true;
            dgMedicos.RowHeadersVisible = false;
            dgMedicos.RowHeadersWidth = 51;
            dgMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMedicos.Size = new Size(858, 423);
            dgMedicos.TabIndex = 1;
            dgMedicos.CellContentClick += dgMedicos_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 516);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
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
            // 
            // FrmMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 571);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgMedicos);
            Name = "FrmMedico";
            Text = "FrmMedico";
            ((System.ComponentModel.ISupportInitialize)dgMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgMedicos;
        private Button btnAgregar;
        private Button btnModificar;
    }
}