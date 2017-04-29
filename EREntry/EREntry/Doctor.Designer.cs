namespace EREntry
{
    partial class Doctor
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
            this.prescribemeds = new System.Windows.Forms.Button();
            this.ordertest = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.diagnose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prescribemeds
            // 
            this.prescribemeds.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescribemeds.Location = new System.Drawing.Point(12, 12);
            this.prescribemeds.Name = "prescribemeds";
            this.prescribemeds.Size = new System.Drawing.Size(106, 54);
            this.prescribemeds.TabIndex = 15;
            this.prescribemeds.Text = "Prescribe meds";
            this.prescribemeds.UseVisualStyleBackColor = true;
            this.prescribemeds.Click += new System.EventHandler(this.prescribemeds_Click);
            // 
            // ordertest
            // 
            this.ordertest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertest.Location = new System.Drawing.Point(124, 12);
            this.ordertest.Name = "ordertest";
            this.ordertest.Size = new System.Drawing.Size(106, 54);
            this.ordertest.TabIndex = 15;
            this.ordertest.Text = "Order test";
            this.ordertest.UseVisualStyleBackColor = true;
            this.ordertest.Click += new System.EventHandler(this.ordertest_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(124, 72);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 54);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // diagnose
            // 
            this.diagnose.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnose.Location = new System.Drawing.Point(236, 11);
            this.diagnose.Name = "diagnose";
            this.diagnose.Size = new System.Drawing.Size(106, 54);
            this.diagnose.TabIndex = 15;
            this.diagnose.Text = "Diagnose";
            this.diagnose.UseVisualStyleBackColor = true;
            this.diagnose.Click += new System.EventHandler(this.diagnose_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 134);
            this.Controls.Add(this.back);
            this.Controls.Add(this.diagnose);
            this.Controls.Add(this.ordertest);
            this.Controls.Add(this.prescribemeds);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button prescribemeds;
        private System.Windows.Forms.Button ordertest;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button diagnose;
    }
}