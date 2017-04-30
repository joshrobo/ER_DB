namespace EREntry
{
    partial class CheckVitals
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
            this.bloodpressure = new System.Windows.Forms.TextBox();
            this.patientid = new System.Windows.Forms.TextBox();
            this.heartrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bloodpressure
            // 
            this.bloodpressure.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodpressure.Location = new System.Drawing.Point(418, 63);
            this.bloodpressure.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bloodpressure.MaxLength = 8;
            this.bloodpressure.Name = "bloodpressure";
            this.bloodpressure.Size = new System.Drawing.Size(180, 45);
            this.bloodpressure.TabIndex = 49;
            // 
            // patientid
            // 
            this.patientid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(29, 63);
            this.patientid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.patientid.MaxLength = 8;
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(180, 45);
            this.patientid.TabIndex = 50;
            // 
            // heartrate
            // 
            this.heartrate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartrate.Location = new System.Drawing.Point(224, 63);
            this.heartrate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.heartrate.MaxLength = 3;
            this.heartrate.Name = "heartrate";
            this.heartrate.Size = new System.Drawing.Size(180, 45);
            this.heartrate.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 45;
            this.label2.Text = "Blood pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Patient ID";
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(216, 17);
            this.First.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(142, 37);
            this.First.TabIndex = 48;
            this.First.Text = "Heart rate";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(224, 127);
            this.submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(183, 54);
            this.submit.TabIndex = 52;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // CheckVitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 201);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.bloodpressure);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.heartrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.First);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CheckVitals";
            this.Text = "CheckVitals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bloodpressure;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.TextBox heartrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label First;
        private System.Windows.Forms.Button submit;
    }
}