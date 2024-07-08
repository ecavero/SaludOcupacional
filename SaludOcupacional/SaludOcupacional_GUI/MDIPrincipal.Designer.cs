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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            empleadoToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            médicoToolStripMenuItem = new ToolStripMenuItem();
            auditoriaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblSesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            auditoriaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadoToolStripMenuItem, pacienteToolStripMenuItem, médicoToolStripMenuItem, auditoriaToolStripMenuItem });
            usuariosToolStripMenuItem.Image = Properties.Resources.star_green;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(126, 24);
            usuariosToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // empleadoToolStripMenuItem
            // 
            empleadoToolStripMenuItem.Image = Properties.Resources.user1;
            empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            empleadoToolStripMenuItem.Size = new Size(184, 26);
            empleadoToolStripMenuItem.Text = "&Empleado";
            empleadoToolStripMenuItem.Click += empleadoToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Image = Properties.Resources.user1;
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(184, 26);
            pacienteToolStripMenuItem.Text = "&Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // médicoToolStripMenuItem
            // 
            médicoToolStripMenuItem.Image = Properties.Resources.user1;
            médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            médicoToolStripMenuItem.Size = new Size(184, 26);
            médicoToolStripMenuItem.Text = "Médico";
            médicoToolStripMenuItem.Click += médicoToolStripMenuItem_Click;
            // 
            // auditoriaToolStripMenuItem
            // 
            auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            auditoriaToolStripMenuItem.Size = new Size(184, 26);
            auditoriaToolStripMenuItem.Text = "Auditoria";
            auditoriaToolStripMenuItem.Click += auditoriaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Image = Properties.Resources.star_grey;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 24);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Image = Properties.Resources.Shutdown_32x32_32;
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(159, 22);
            salirDelSistemaToolStripMenuItem.Text = "&Salir del Sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblSesion });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.ButtonFace;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(50, 17);
            lblEquipo.Text = "Equipo: ";
            // 
            // lblSesion
            // 
            lblSesion.BackColor = SystemColors.Highlight;
            lblSesion.ForeColor = SystemColors.ButtonHighlight;
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(106, 17);
            lblSesion.Text = "Tiempo de sesión: ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // auditoriaToolStripMenuItem
            // 
            auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            auditoriaToolStripMenuItem.Size = new Size(184, 26);
            auditoriaToolStripMenuItem.Text = "Auditoria";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Salud_Ocupacional_32;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MDIPrincipal";
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblSesion;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem auditoriaToolStripMenuItem;
    }
}
