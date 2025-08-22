using MedicalBookingApp.Forms;
using System;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Open Doctor List Form
        private void BtnViewDoctors_Click(object sender, EventArgs e)
        {
            DoctorListForm doctorForm = new DoctorListForm();
            doctorForm.ShowDialog();
        }

        // Open Appointment Booking Form
        private void BtnBookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();
        }

        // Open Manage Appointments Form
        private void BtnManageAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageForm = new ManageAppointmentsForm();
            manageForm.ShowDialog();
        }
    }
}
