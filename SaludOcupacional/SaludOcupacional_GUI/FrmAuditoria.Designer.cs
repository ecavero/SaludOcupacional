namespace SaludOcupacional_GUI
{
    partial class FrmAuditoria
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
            auditDataGrid = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            TableName = new DataGridViewTextBoxColumn();
            Timestamp = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            buttonAccept = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)auditDataGrid).BeginInit();
            SuspendLayout();
            // 
            // auditDataGrid
            // 
            auditDataGrid.AllowUserToAddRows = false;
            auditDataGrid.AllowUserToDeleteRows = false;
            auditDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            auditDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            auditDataGrid.Columns.AddRange(new DataGridViewColumn[] { UserName, Action, TableName, Timestamp, Details });
            auditDataGrid.Location = new Point(51, 51);
            auditDataGrid.Margin = new Padding(3, 4, 3, 4);
            auditDataGrid.Name = "auditDataGrid";
            auditDataGrid.ReadOnly = true;
            auditDataGrid.RowHeadersVisible = false;
            auditDataGrid.RowHeadersWidth = 51;
            auditDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            auditDataGrid.Size = new Size(809, 451);
            auditDataGrid.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "Usuario";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Action
            // 
            Action.DataPropertyName = "Action";
            Action.HeaderText = "Acción";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // TableName
            // 
            TableName.DataPropertyName = "TableName";
            TableName.HeaderText = "Tabla";
            TableName.MinimumWidth = 6;
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            // 
            // Timestamp
            // 
            Timestamp.DataPropertyName = "Timestamp";
            Timestamp.HeaderText = "Fecha y Hora";
            Timestamp.MinimumWidth = 6;
            Timestamp.Name = "Timestamp";
            Timestamp.ReadOnly = true;
            // 
            // Details
            // 
            Details.DataPropertyName = "Details";
            Details.HeaderText = "Detalles";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.ReadOnly = true;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(51, 529);
            buttonAccept.Margin = new Padding(3, 4, 3, 4);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(86, 31);
            buttonAccept.TabIndex = 1;
            buttonAccept.Text = "Ok";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += button1_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(764, 529);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(96, 29);
            lblRegistros.TabIndex = 3;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 529);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Registros:";
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(buttonAccept);
            Controls.Add(auditDataGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAuditoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabla de Auditoría";
            Load += FrmAuditoria_Load;
            ((System.ComponentModel.ISupportInitialize)auditDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView auditDataGrid;
        private Button buttonAccept;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Action;
        private DataGridViewTextBoxColumn TableName;
        private DataGridViewTextBoxColumn Timestamp;
        private DataGridViewTextBoxColumn Details;
        private Label lblRegistros;
        private Label label2;
    }
}