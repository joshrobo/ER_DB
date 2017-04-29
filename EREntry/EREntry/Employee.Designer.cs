namespace EREntry
{
    partial class Employee
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
            this.getrecords = new System.Windows.Forms.Button();
            this.assignnurse = new System.Windows.Forms.Button();
            this.assigndoctor = new System.Windows.Forms.Button();
            this.checkinpatient = new System.Windows.Forms.Button();
            this.findpatient = new System.Windows.Forms.Button();
            this.addmeds = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.checkoutpatient = new System.Windows.Forms.Button();
            this.createemployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getrecords
            // 
            this.getrecords.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getrecords.Location = new System.Drawing.Point(234, 72);
            this.getrecords.Name = "getrecords";
            this.getrecords.Size = new System.Drawing.Size(106, 54);
            this.getrecords.TabIndex = 8;
            this.getrecords.Text = "Get patient records";
            this.getrecords.UseVisualStyleBackColor = true;
            this.getrecords.Click += new System.EventHandler(this.getrecords_Click);
            // 
            // assignnurse
            // 
            this.assignnurse.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignnurse.Location = new System.Drawing.Point(123, 12);
            this.assignnurse.Name = "assignnurse";
            this.assignnurse.Size = new System.Drawing.Size(106, 54);
            this.assignnurse.TabIndex = 9;
            this.assignnurse.Text = "Assign nurse";
            this.assignnurse.UseVisualStyleBackColor = true;
            this.assignnurse.Click += new System.EventHandler(this.assignnurse_Click);
            // 
            // assigndoctor
            // 
            this.assigndoctor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigndoctor.Location = new System.Drawing.Point(235, 12);
            this.assigndoctor.Name = "assigndoctor";
            this.assigndoctor.Size = new System.Drawing.Size(106, 54);
            this.assigndoctor.TabIndex = 10;
            this.assigndoctor.Text = "Assign doctor";
            this.assigndoctor.UseVisualStyleBackColor = true;
            this.assigndoctor.Click += new System.EventHandler(this.assigndoctor_Click);
            // 
            // checkinpatient
            // 
            this.checkinpatient.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinpatient.Location = new System.Drawing.Point(11, 72);
            this.checkinpatient.Name = "checkinpatient";
            this.checkinpatient.Size = new System.Drawing.Size(106, 54);
            this.checkinpatient.TabIndex = 11;
            this.checkinpatient.Text = "Check in patient";
            this.checkinpatient.UseVisualStyleBackColor = true;
            this.checkinpatient.Click += new System.EventHandler(this.checkinpatient_Click);
            // 
            // findpatient
            // 
            this.findpatient.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findpatient.Location = new System.Drawing.Point(12, 132);
            this.findpatient.Name = "findpatient";
            this.findpatient.Size = new System.Drawing.Size(106, 54);
            this.findpatient.TabIndex = 12;
            this.findpatient.Text = "Find patient";
            this.findpatient.UseVisualStyleBackColor = true;
            this.findpatient.Click += new System.EventHandler(this.findpatient_Click);
            // 
            // addmeds
            // 
            this.addmeds.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmeds.Location = new System.Drawing.Point(11, 12);
            this.addmeds.Name = "addmeds";
            this.addmeds.Size = new System.Drawing.Size(106, 54);
            this.addmeds.TabIndex = 12;
            this.addmeds.Text = "Add meds";
            this.addmeds.UseVisualStyleBackColor = true;
            this.addmeds.Click += new System.EventHandler(this.addmeds_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(234, 132);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 54);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // checkoutpatient
            // 
            this.checkoutpatient.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutpatient.Location = new System.Drawing.Point(123, 72);
            this.checkoutpatient.Name = "checkoutpatient";
            this.checkoutpatient.Size = new System.Drawing.Size(106, 54);
            this.checkoutpatient.TabIndex = 12;
            this.checkoutpatient.Text = "Check out patient";
            this.checkoutpatient.UseVisualStyleBackColor = true;
            this.checkoutpatient.Click += new System.EventHandler(this.checkoutpatient_Click);
            // 
            // createemployee
            // 
            this.createemployee.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createemployee.Location = new System.Drawing.Point(124, 132);
            this.createemployee.Name = "createemployee";
            this.createemployee.Size = new System.Drawing.Size(106, 54);
            this.createemployee.TabIndex = 13;
            this.createemployee.Text = "New employee";
            this.createemployee.UseVisualStyleBackColor = true;
            this.createemployee.Click += new System.EventHandler(this.createemployee_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 199);
            this.Controls.Add(this.createemployee);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addmeds);
            this.Controls.Add(this.checkoutpatient);
            this.Controls.Add(this.findpatient);
            this.Controls.Add(this.checkinpatient);
            this.Controls.Add(this.assigndoctor);
            this.Controls.Add(this.assignnurse);
            this.Controls.Add(this.getrecords);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getrecords;
        private System.Windows.Forms.Button assignnurse;
        private System.Windows.Forms.Button assigndoctor;
        private System.Windows.Forms.Button checkinpatient;
        private System.Windows.Forms.Button findpatient;
        private System.Windows.Forms.Button addmeds;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button checkoutpatient;
        private System.Windows.Forms.Button createemployee;
    }
}