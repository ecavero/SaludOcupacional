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
            buttonAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)auditDataGrid).BeginInit();
            SuspendLayout();
            // 
            // auditDataGrid
            // 
            auditDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            auditDataGrid.Location = new Point(45, 38);
            auditDataGrid.Name = "auditDataGrid";
            auditDataGrid.Size = new Size(708, 338);
            auditDataGrid.TabIndex = 0;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(45, 397);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(75, 23);
            buttonAccept.TabIndex = 1;
            buttonAccept.Text = "Ok";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += button1_Click;
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAccept);
            Controls.Add(auditDataGrid);
            Name = "FrmAuditoria";
            Text = "FrmAuditoria";
            ((System.ComponentModel.ISupportInitialize)auditDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView auditDataGrid;
        private Button buttonAccept;
    }
}