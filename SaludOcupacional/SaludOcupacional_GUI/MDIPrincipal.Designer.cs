namespace SaludOcupacional_GUI
{
    partial class MDIPrincipal
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
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            médicoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadoToolStripMenuItem, pacienteToolStripMenuItem, médicoToolStripMenuItem });
            usuariosToolStripMenuItem.Image = Properties.Resources.star_green;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(150, 24);
            usuariosToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.Image = Properties.Resources.user1;
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(224, 26);
            empleadoToolStripMenuItem.Text = "&Empleado";
            empleadoToolStripMenuItem.Click += empleadoToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Image = Properties.Resources.user1;
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(224, 26);
            pacienteToolStripMenuItem.Text = "&Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // médicoToolStripMenuItem
            // 
            médicoToolStripMenuItem.Image = Properties.Resources.user1;
            médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            médicoToolStripMenuItem.Size = new Size(224, 26);
            médicoToolStripMenuItem.Text = "Médico";
            médicoToolStripMenuItem.Click += médicoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Image = Properties.Resources.star_grey;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(72, 24);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Image = Properties.Resources.Shutdown_32x32_32;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(202, 26);
            salirDelSistemaToolStripMenuItem.Text = "&Salir del Sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Salud_Ocupacional_3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MDIPrincipal";
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem médicoToolStripMenuItem;
    }
}
