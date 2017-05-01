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
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dosage
            // 
            this.dosage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosage.Location = new System.Drawing.Point(418, 63);
            this.dosage.Margin = new System.Windows.Forms.Padding(6);
            this.dosage.MaxLength = 4;
            this.dosage.Name = "dosage";
            this.dosage.Size = new System.Drawing.Size(180, 45);
            this.dosage.TabIndex = 48;
            // 
            // patientid
            // 
            this.patientid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(224, 63);
            this.patientid.Margin = new System.Windows.Forms.Padding(6);
            this.patientid.MaxLength = 8;
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(180, 45);
            this.patientid.TabIndex = 49;
            // 
            // medid
            // 
            this.medid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medid.Location = new System.Drawing.Point(29, 63);
            this.medid.Margin = new System.Windows.Forms.Padding(6);
            this.medid.MaxLength = 8;
            this.medid.Name = "medid";
            this.medid.Size = new System.Drawing.Size(180, 45);
            this.medid.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 45;
            this.label2.Text = "Dosage *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Patient ID *";
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(22, 17);
            this.First.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(130, 37);
            this.First.TabIndex = 47;
            this.First.Text = "Med ID *";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(326, 127);
            this.submit.Margin = new System.Windows.Forms.Padding(6);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(169, 54);
            this.submit.TabIndex = 51;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 45;
            this.label3.Text = "Doctor ID*";
            // 
            // doctorid
            // 
            this.doctorid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorid.Location = new System.Drawing.Point(620, 63);
            this.doctorid.Margin = new System.Windows.Forms.Padding(6);
            this.doctorid.MaxLength = 4;
            this.doctorid.Name = "doctorid";
            this.doctorid.Size = new System.Drawing.Size(180, 45);
            this.doctorid.TabIndex = 48;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(333, 187);
            this.output.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(146, 37);
            this.output.TabIndex = 52;
            this.output.Text = "*  required";
            // 
            // PrescribeMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 237);
            this.Controls.Add(this.output);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.doctorid);
            this.Controls.Add(this.dosage);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.medid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.First);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        public System.Windows.Forms.TextBox doctorid;
        public System.Windows.Forms.Label output;
    }
}