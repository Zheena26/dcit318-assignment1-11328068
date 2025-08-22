namespace MedicalBookingApp
{
    partial class AppointmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNotes;

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
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(20, 20);
            this.lblDoctor.Text = "Doctor:";
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctors.Location = new System.Drawing.Point(120, 20);
            this.cmbDoctors.Size = new System.Drawing.Size(250, 28);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(20, 70);
            this.lblPatient.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(120, 70);
            this.txtPatientName.Size = new System.Drawing.Size(250, 27);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 120);
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 120);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 170);
            this.lblTime.Text = "Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(120, 170);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(250, 27);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(20, 220);
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(120, 220);
            this.txtNotes.Size = new System.Drawing.Size(250, 80);
            this.txtNotes.Multiline = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(120, 320);
            this.btnBook.Text = "Book Appointment";
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // AppointmentForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnBook);
            this.Text = "Book Appointment";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
