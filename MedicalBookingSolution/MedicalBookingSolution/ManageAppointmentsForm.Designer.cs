namespace MedicalBookingApp.Forms
{
    partial class ManageAppointmentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNewDate;

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
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNewDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNewDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewAppointments.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // lblNewDate
            // 
            this.lblNewDate.Text = "New Date:";
            this.lblNewDate.Location = new System.Drawing.Point(20, 340);
            this.lblNewDate.AutoSize = true;
            // 
            // dateTimePickerNewDate
            // 
            this.dateTimePickerNewDate.Location = new System.Drawing.Point(100, 340);
            this.dateTimePickerNewDate.Width = 200;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "Update Appointment";
            this.btnUpdate.Location = new System.Drawing.Point(320, 340);
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Text = "Delete Appointment";
            this.btnDelete.Location = new System.Drawing.Point(480, 340);
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ManageAppointmentsForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.lblNewDate);
            this.Controls.Add(this.dateTimePickerNewDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "ManageAppointmentsForm";
            this.Text = "Manage Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
