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
            btnAgregar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgPacientes
            // 
            dgPacientes.AllowUserToAddRows = false;
            dgPacientes.AllowUserToDeleteRows = false;
            dgPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPacientes.Location = new Point(33, 61);
            dgPacientes.Name = "dgPacientes";
            dgPacientes.ReadOnly = true;
            dgPacientes.RowHeadersVisible = false;
            dgPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPacientes.Size = new Size(745, 317);
            dgPacientes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 402);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(126, 402);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgPacientes);
            Name = "frmPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPacientes;
        private Button btnAgregar;
        private Button btnModificar;
    }
}
