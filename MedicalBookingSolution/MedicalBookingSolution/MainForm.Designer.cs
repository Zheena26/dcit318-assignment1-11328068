namespace MedicalBookingApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnViewDoctors;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnManageAppointments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnViewDoctors = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnManageAppointments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewDoctors
            // 
            this.btnViewDoctors.Location = new System.Drawing.Point(50, 40);
            this.btnViewDoctors.Name = "btnViewDoctors";
            this.btnViewDoctors.Size = new System.Drawing.Size(200, 40);
            this.btnViewDoctors.TabIndex = 0;
            this.btnViewDoctors.Text = "View Doctors";
            this.btnViewDoctors.UseVisualStyleBackColor = true;
            this.btnViewDoctors.Click += new System.EventHandler(this.BtnViewDoctors_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(50, 100);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(200, 40);
            this.btnBookAppointment.TabIndex = 1;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.BtnBookAppointment_Click);
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.Location = new System.Drawing.Point(50, 160);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(200, 40);
            this.btnManageAppointments.TabIndex = 2;
            this.btnManageAppointments.Text = "Manage Appointments";
            this.btnManageAppointments.UseVisualStyleBackColor = true;
            this.btnManageAppointments.Click += new System.EventHandler(this.BtnManageAppointments_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.btnViewDoctors);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.btnManageAppointments);
            this.Name = "MainForm";
            this.Text = "Medical Booking App";
            this.ResumeLayout(false);
        }
    }
}
