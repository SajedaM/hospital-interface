namespace Hospital_Management
{
    partial class add_doctor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.comboSection = new System.Windows.Forms.ComboBox();
            this.btnSaveDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(26, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(26, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textName.Location = new System.Drawing.Point(151, 77);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(372, 32);
            this.textName.TabIndex = 1;
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textPhone.Location = new System.Drawing.Point(151, 134);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(372, 32);
            this.textPhone.TabIndex = 1;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textAddress.Location = new System.Drawing.Point(151, 243);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(372, 32);
            this.textAddress.TabIndex = 1;
            // 
            // comboSection
            // 
            this.comboSection.Font = new System.Drawing.Font("Tahoma", 15F);
            this.comboSection.FormattingEnabled = true;
            this.comboSection.Items.AddRange(new object[] {
            "ENT(Ear,Nose and throat)",
            "Ophthalmology",
            "Neurology",
            "Nephrology",
            "Internal Medicine",
            "Endocrinology",
            "Cardiology",
            "Pediatrics"});
            this.comboSection.Location = new System.Drawing.Point(151, 193);
            this.comboSection.Name = "comboSection";
            this.comboSection.Size = new System.Drawing.Size(372, 32);
            this.comboSection.TabIndex = 2;
            // 
            // btnSaveDoctor
            // 
            this.btnSaveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDoctor.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveDoctor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoctor.Location = new System.Drawing.Point(151, 323);
            this.btnSaveDoctor.Name = "btnSaveDoctor";
            this.btnSaveDoctor.Size = new System.Drawing.Size(372, 75);
            this.btnSaveDoctor.TabIndex = 3;
            this.btnSaveDoctor.Text = "Save Information";
            this.btnSaveDoctor.UseVisualStyleBackColor = true;
            this.btnSaveDoctor.Click += new System.EventHandler(this.btnSaveDoctor_Click);
            // 
            // add_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 480);
            this.Controls.Add(this.btnSaveDoctor);
            this.Controls.Add(this.comboSection);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "add_doctor";
            this.Text = "add_doctor";
            this.Load += new System.EventHandler(this.add_doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ComboBox comboSection;
        private System.Windows.Forms.Button btnSaveDoctor;
    }
}