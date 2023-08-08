namespace Hospital_Management
{
    partial class edit_doctor
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
            this.btnSaveDoctor = new System.Windows.Forms.Button();
            this.comboSection = new System.Windows.Forms.ComboBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveDoctor
            // 
            this.btnSaveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDoctor.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveDoctor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveDoctor.Location = new System.Drawing.Point(143, 333);
            this.btnSaveDoctor.Name = "btnSaveDoctor";
            this.btnSaveDoctor.Size = new System.Drawing.Size(372, 75);
            this.btnSaveDoctor.TabIndex = 14;
            this.btnSaveDoctor.Text = "Save Information";
            this.btnSaveDoctor.UseVisualStyleBackColor = true;
            this.btnSaveDoctor.Click += new System.EventHandler(this.btnSaveDoctor_Click);
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
            this.comboSection.Location = new System.Drawing.Point(143, 203);
            this.comboSection.Name = "comboSection";
            this.comboSection.Size = new System.Drawing.Size(372, 32);
            this.comboSection.TabIndex = 13;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textAddress.Location = new System.Drawing.Point(143, 253);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(372, 32);
            this.textAddress.TabIndex = 9;
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textPhone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textPhone.Location = new System.Drawing.Point(143, 144);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(372, 32);
            this.textPhone.TabIndex = 10;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textName.Location = new System.Drawing.Point(143, 87);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(372, 32);
            this.textName.TabIndex = 11;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textID.Location = new System.Drawing.Point(143, 37);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(372, 32);
            this.textID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(18, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(18, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "id";
            // 
            // edit_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.btnSaveDoctor);
            this.Controls.Add(this.comboSection);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "edit_doctor";
            this.Text = "edit_doctor";
            this.Load += new System.EventHandler(this.edit_doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboSection;
        public System.Windows.Forms.TextBox textAddress;
        public System.Windows.Forms.TextBox textPhone;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.TextBox textID;
    }
}