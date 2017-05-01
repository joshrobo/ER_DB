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
            this.IDlabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.viewtest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // performtest
            // 
            this.performtest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performtest.Location = new System.Drawing.Point(230, 94);
            this.performtest.Margin = new System.Windows.Forms.Padding(6);
            this.performtest.Name = "performtest";
            this.performtest.Size = new System.Drawing.Size(194, 100);
            this.performtest.TabIndex = 9;
            this.performtest.Text = "Perform test";
            this.performtest.UseVisualStyleBackColor = true;
            this.performtest.Click += new System.EventHandler(this.performtest_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(132, 206);
            this.back.Margin = new System.Windows.Forms.Padding(6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(194, 100);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(113, 24);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(56, 37);
            this.IDlabel.TabIndex = 20;
            this.IDlabel.Text = "ID:";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(230, 21);
            this.idBox.Margin = new System.Windows.Forms.Padding(6);
            this.idBox.MaxLength = 4;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(194, 45);
            this.idBox.TabIndex = 19;
            // 
            // viewtest
            // 
            this.viewtest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewtest.Location = new System.Drawing.Point(24, 94);
            this.viewtest.Margin = new System.Windows.Forms.Padding(6);
            this.viewtest.Name = "viewtest";
            this.viewtest.Size = new System.Drawing.Size(194, 100);
            this.viewtest.TabIndex = 21;
            this.viewtest.Text = "View test";
            this.viewtest.UseVisualStyleBackColor = true;
            this.viewtest.Click += new System.EventHandler(this.viewtest_Click);
            // 
            // LabTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 321);
            this.Controls.Add(this.viewtest);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.performtest);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LabTech";
            this.Text = "LabTech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button performtest;
        private System.Windows.Forms.Button back;
        public System.Windows.Forms.Label IDlabel;
        public System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button viewtest;
    }
}