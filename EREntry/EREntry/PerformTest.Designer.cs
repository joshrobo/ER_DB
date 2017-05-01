namespace EREntry
{
    partial class PerformTest
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
            this.labid = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.Label();
            this.techid = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labid
            // 
            this.labid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labid.Location = new System.Drawing.Point(29, 63);
            this.labid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labid.MaxLength = 11;
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(180, 45);
            this.labid.TabIndex = 44;
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(22, 17);
            this.First.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(120, 37);
            this.First.TabIndex = 43;
            this.First.Text = "Lab ID *";
            // 
            // techid
            // 
            this.techid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techid.Location = new System.Drawing.Point(224, 63);
            this.techid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.techid.MaxLength = 4;
            this.techid.Name = "techid";
            this.techid.Size = new System.Drawing.Size(180, 45);
            this.techid.TabIndex = 44;
            // 
            // results
            // 
            this.results.AllowDrop = true;
            this.results.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(29, 168);
            this.results.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.results.MaxLength = 200;
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results.Size = new System.Drawing.Size(569, 406);
            this.results.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lab tech ID *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Results *";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(224, 589);
            this.submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(183, 54);
            this.submit.TabIndex = 45;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // PerformTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 665);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.techid);
            this.Controls.Add(this.results);
            this.Controls.Add(this.labid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.First);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PerformTest";
            this.Text = "PerformTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox labid;
        private System.Windows.Forms.Label First;
        public System.Windows.Forms.TextBox techid;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
    }
}