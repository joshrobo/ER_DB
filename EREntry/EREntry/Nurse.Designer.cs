namespace EREntry
{
    partial class Nurse
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
            this.checkvitals = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkvitals
            // 
            this.checkvitals.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkvitals.Location = new System.Drawing.Point(12, 12);
            this.checkvitals.Name = "checkvitals";
            this.checkvitals.Size = new System.Drawing.Size(106, 54);
            this.checkvitals.TabIndex = 9;
            this.checkvitals.Text = "Check vitals";
            this.checkvitals.UseVisualStyleBackColor = true;
            this.checkvitals.Click += new System.EventHandler(this.checkvitals_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(124, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 54);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 78);
            this.Controls.Add(this.back);
            this.Controls.Add(this.checkvitals);
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkvitals;
        private System.Windows.Forms.Button back;
    }
}