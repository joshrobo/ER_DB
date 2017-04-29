namespace EREntry
{
    partial class PrescribeMeds
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
            this.dosage = new System.Windows.Forms.TextBox();
            this.patientid = new System.Windows.Forms.TextBox();
            this.medid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dosage
            // 
            this.dosage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosage.Location = new System.Drawing.Point(228, 34);
            this.dosage.Name = "dosage";
            this.dosage.Size = new System.Drawing.Size(100, 29);
            this.dosage.TabIndex = 48;
            // 
            // patientid
            // 
            this.patientid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(122, 34);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(100, 29);
            this.patientid.TabIndex = 49;
            // 
            // medid
            // 
            this.medid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medid.Location = new System.Drawing.Point(16, 34);
            this.medid.Name = "medid";
            this.medid.Size = new System.Drawing.Size(100, 29);
            this.medid.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Dosage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Patient ID";
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(12, 9);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(62, 22);
            this.First.TabIndex = 47;
            this.First.Text = "Med ID";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(178, 69);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 29);
            this.submit.TabIndex = 51;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Doctor ID";
            // 
            // doctorid
            // 
            this.doctorid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorid.Location = new System.Drawing.Point(338, 34);
            this.doctorid.Name = "doctorid";
            this.doctorid.Size = new System.Drawing.Size(100, 29);
            this.doctorid.TabIndex = 48;
            // 
            // PrescribeMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 107);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.doctorid);
            this.Controls.Add(this.dosage);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.medid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.First);
            this.Name = "PrescribeMeds";
            this.Text = "PrescribeMeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dosage;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.TextBox medid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label First;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctorid;
    }
}