namespace EREntry
{
    partial class LabTech
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
            this.performtest = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // performtest
            // 
            this.performtest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performtest.Location = new System.Drawing.Point(12, 12);
            this.performtest.Name = "performtest";
            this.performtest.Size = new System.Drawing.Size(106, 54);
            this.performtest.TabIndex = 9;
            this.performtest.Text = "Perform test";
            this.performtest.UseVisualStyleBackColor = true;
            this.performtest.Click += new System.EventHandler(this.performtest_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(124, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 54);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // LabTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 79);
            this.Controls.Add(this.back);
            this.Controls.Add(this.performtest);
            this.Name = "LabTech";
            this.Text = "LabTech";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button performtest;
        private System.Windows.Forms.Button back;
    }
}