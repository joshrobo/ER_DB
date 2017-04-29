namespace EREntry
{
    partial class Home
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
            this.doctor = new System.Windows.Forms.Button();
            this.nurse = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.labtech = new System.Windows.Forms.Button();
            this.patient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctor
            // 
            this.doctor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor.Location = new System.Drawing.Point(107, 46);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(81, 39);
            this.doctor.TabIndex = 1;
            this.doctor.Text = "Doctor";
            this.doctor.UseVisualStyleBackColor = true;
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // nurse
            // 
            this.nurse.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurse.Location = new System.Drawing.Point(194, 46);
            this.nurse.Name = "nurse";
            this.nurse.Size = new System.Drawing.Size(81, 39);
            this.nurse.TabIndex = 2;
            this.nurse.Text = "Nurse";
            this.nurse.UseVisualStyleBackColor = true;
            this.nurse.Click += new System.EventHandler(this.nurse_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(55, 91);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(92, 39);
            this.employee.TabIndex = 3;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // labtech
            // 
            this.labtech.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtech.Location = new System.Drawing.Point(153, 91);
            this.labtech.Name = "labtech";
            this.labtech.Size = new System.Drawing.Size(92, 39);
            this.labtech.TabIndex = 4;
            this.labtech.Text = "Lab Tech";
            this.labtech.UseVisualStyleBackColor = true;
            this.labtech.Click += new System.EventHandler(this.labtech_Click);
            // 
            // patient
            // 
            this.patient.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.Location = new System.Drawing.Point(20, 46);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(81, 39);
            this.patient.TabIndex = 5;
            this.patient.Text = "Patient";
            this.patient.UseVisualStyleBackColor = true;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 36);
            this.label10.TabIndex = 21;
            this.label10.Text = "Home";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 146);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.labtech);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.nurse);
            this.Controls.Add(this.doctor);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button doctor;
        private System.Windows.Forms.Button nurse;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button labtech;
        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Label label10;
    }
}