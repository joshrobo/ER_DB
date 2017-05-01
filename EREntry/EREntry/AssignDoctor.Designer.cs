namespace EREntry
{
    partial class AssignDoctor
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
            this.submit.Location = new System.Drawing.Point(22, 127);
            this.submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(191, 54);
            this.submit.TabIndex = 36;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // patientid
            // 
            this.patientid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid.Location = new System.Drawing.Point(29, 63);
            this.patientid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.patientid.MaxLength = 8;
            this.patientid.Name = "patientid";
            this.patientid.Size = new System.Drawing.Size(180, 45);
            this.patientid.TabIndex = 35;
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(22, 17);
            this.First.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(178, 37);
            this.First.TabIndex = 34;
            this.First.Text = "To patient ID";
            // 
            // AssignDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 209);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.patientid);
            this.Controls.Add(this.First);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AssignDoctor";
            this.Text = "AssignDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox patientid;
        private System.Windows.Forms.Label First;
    }
}