namespace EREntry
{
    partial class AddMeds
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
            this.name = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(17, 66);
            this.name.Margin = new System.Windows.Forms.Padding(6);
            this.name.MaxLength = 25;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(180, 45);
            this.name.TabIndex = 2;
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First.Location = new System.Drawing.Point(15, 17);
            this.First.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(91, 37);
            this.First.TabIndex = 3;
            this.First.Text = "Name";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(113, 149);
            this.submit.Margin = new System.Windows.Forms.Padding(6);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(183, 54);
            this.submit.TabIndex = 32;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expiration date";
            // 
            // expdate
            // 
            this.expdate.Font = new System.Drawing.Font("Palatino Linotype", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expdate.Location = new System.Drawing.Point(211, 66);
            this.expdate.Margin = new System.Windows.Forms.Padding(6);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(180, 39);
            this.expdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "YYYY/MM/DD";
            // 
            // AddMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.First);
            this.Controls.Add(this.expdate);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddMeds";
            this.Text = "AddMeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label First;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expdate;
        private System.Windows.Forms.Label label2;
    }
}