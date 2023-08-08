namespace Hospital_Management
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgrammer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.proccessToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.manageDoctorToolStripMenuItem});
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // manageDoctorToolStripMenuItem
            // 
            this.manageDoctorToolStripMenuItem.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.manageDoctorToolStripMenuItem.Name = "manageDoctorToolStripMenuItem";
            this.manageDoctorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.manageDoctorToolStripMenuItem.Text = "Manage Doctor";
            this.manageDoctorToolStripMenuItem.Click += new System.EventHandler(this.manageDoctorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPatientToolStripMenuItem,
            this.sitPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // proccessToolStripMenuItem
            // 
            this.proccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProccessToolStripMenuItem,
            this.manageProccessToolStripMenuItem});
            this.proccessToolStripMenuItem.Name = "proccessToolStripMenuItem";
            this.proccessToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.proccessToolStripMenuItem.Text = "Proccess";
            // 
            // addProccessToolStripMenuItem
            // 
            this.addProccessToolStripMenuItem.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.addProccessToolStripMenuItem.Name = "addProccessToolStripMenuItem";
            this.addProccessToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.addProccessToolStripMenuItem.Text = "Add Proccess";
            this.addProccessToolStripMenuItem.Click += new System.EventHandler(this.addProccessToolStripMenuItem_Click);
            // 
            // manageProccessToolStripMenuItem
            // 
            this.manageProccessToolStripMenuItem.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.manageProccessToolStripMenuItem.Name = "manageProccessToolStripMenuItem";
            this.manageProccessToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.manageProccessToolStripMenuItem.Text = "Manage Proccess";
            this.manageProccessToolStripMenuItem.Click += new System.EventHandler(this.manageProccessToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(170, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management";
            // 
            // labelProgrammer
            // 
            this.labelProgrammer.AutoSize = true;
            this.labelProgrammer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelProgrammer.Location = new System.Drawing.Point(12, 424);
            this.labelProgrammer.Name = "labelProgrammer";
            this.labelProgrammer.Size = new System.Drawing.Size(253, 17);
            this.labelProgrammer.TabIndex = 2;
            this.labelProgrammer.Text = "Programmed By : Eng Sajeda Almomani";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchPatientToolStripMenuItem
            // 
            this.searchPatientToolStripMenuItem.Name = "searchPatientToolStripMenuItem";
            this.searchPatientToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.searchPatientToolStripMenuItem.Text = "Currently Open";
            this.searchPatientToolStripMenuItem.Click += new System.EventHandler(this.searchPatientToolStripMenuItem_Click);
            // 
            // sitPatientToolStripMenuItem
            // 
            this.sitPatientToolStripMenuItem.Name = "sitPatientToolStripMenuItem";
            this.sitPatientToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.sitPatientToolStripMenuItem.Text = "View Patient";
            this.sitPatientToolStripMenuItem.Click += new System.EventHandler(this.sitPatientToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.labelProgrammer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main page";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgrammer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem searchPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitPatientToolStripMenuItem;
    }
}