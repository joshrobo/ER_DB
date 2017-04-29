namespace EREntry
{
    partial class Diagnose
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
            this.label1 = new System.Windows.Forms.Label();
            this.symptoms = new System.Windows.Forms.TextBox();
            this.recordid = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.Label();
            this.patientid = new System.Windows.Forms.TextBox();
            this.diagnosis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Symptoms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Record ID";
            // 
            // symptoms
            // 
            this.symptoms.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms.Location = new System.Drawing.Point(16, 91);
            this.symptoms.Multiline = true;
            this.symptoms.Name = "symptoms";
            this.symptoms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.symptoms.Size = new System.Drawing.Size(313, 91);
            this.symptoms.TabIndex = 29;
            // 
            // recordid
            // 
            this.recordid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordid.Location = new System.Drawing.Point(123, 34);
            this.recordid.Name = "recordid";
            this.recordid.Size = new System.Drawing.Size(100, 29);
            this.recordid.TabIndex = 28;
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(12, 9);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(78, 22);
            this.First.TabIndex = 27;
            this.First.Text = "Patient ID";
            // 
            // patientid
            // 
            this.patientid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(16, 34);
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(100, 29);
            this.patientid.TabIndex = 26;
            // 
            // diagnosis
            // 
            this.diagnosis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis.Location = new System.Drawing.Point(16, 210);
            this.diagnosis.Multiline = true;
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.diagnosis.Size = new System.Drawing.Size(313, 91);
            this.diagnosis.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Diagnosis";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(123, 307);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 29);
            this.submit.TabIndex = 41;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Diagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 349);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.symptoms);
            this.Controls.Add(this.recordid);
            this.Controls.Add(this.First);
            this.Controls.Add(this.patientid);
            this.Name = "Diagnose";
            this.Text = "Diagnose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox symptoms;
        private System.Windows.Forms.TextBox recordid;
        private System.Windows.Forms.Label First;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.TextBox diagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
    }
}