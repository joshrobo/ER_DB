namespace EREntry
{
    partial class CheckInPatient
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
            this.submit = new System.Windows.Forms.Button();
            this.patientid = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(16, 69);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 29);
            this.submit.TabIndex = 39;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // patientid
            // 
            this.patientid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(16, 34);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(100, 29);
            this.patientid.TabIndex = 38;
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(12, 9);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(78, 22);
            this.First.TabIndex = 37;
            this.First.Text = "Patient ID";
            // 
            // CheckInPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 118);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.First);
            this.Name = "CheckInPatient";
            this.Text = "CheckInPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.Label First;
    }
}