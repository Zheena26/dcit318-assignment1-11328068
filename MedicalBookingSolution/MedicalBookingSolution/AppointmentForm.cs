using MedicalBookingApp.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        // Load doctors into combo box
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT DoctorID, FullName FROM Doctors";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cmbDoctors.DataSource = dt;
            cmbDoctors.DisplayMember = "FullName";
            cmbDoctors.ValueMember = "DoctorID";
        }

        // Book appointment
        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (cmbDoctors.SelectedValue == null || string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                MessageBox.Show("Please select a doctor and enter patient name.");
                return;
            }

            int doctorId = Convert.ToInt32(cmbDoctors.SelectedValue);
            string patientName = txtPatientName.Text.Trim();
            DateTime appointmentDate = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            string notes = txtNotes.Text.Trim();

            string query = @"INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, Notes)
                             VALUES (@doctorId, (SELECT PatientID FROM Patients WHERE FullName = @patientName), @date, @notes)";

            try
            {
                int rows = DatabaseHelper.ExecuteNonQuery(
                    query,
                    new SqlParameter("@doctorId", doctorId),
                    new SqlParameter("@patientName", patientName),
                    new SqlParameter("@date", appointmentDate),
                    new SqlParameter("@notes", notes)
                );

                if (rows > 0)
                {
                    MessageBox.Show("Appointment booked successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to book appointment. Make sure patient exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
