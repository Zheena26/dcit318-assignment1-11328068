using System;
using System.Data;
using System.Windows.Forms;
using MedicalBookingApp.Helpers;
using Microsoft.Data.SqlClient;  // ✅ use Microsoft.Data.SqlClient

namespace MedicalBookingApp.Forms
{
    public partial class ManageAppointmentsForm : Form
    {
        private DataTable table;

        public ManageAppointmentsForm()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            string query = @"SELECT A.AppointmentID, P.FullName AS Patient, D.FullName AS Doctor, 
                                    A.AppointmentDate, A.Notes
                             FROM Appointments A
                             JOIN Patients P ON A.PatientID = P.PatientID
                             JOIN Doctors D ON A.DoctorID = D.DoctorID";

            table = DatabaseHelper.ExecuteQuery(query);
            dataGridViewAppointments.DataSource = table;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 0) return;

            int appointmentId = (int)dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value;
            DateTime newDate = dateTimePickerNewDate.Value;

            string query = "UPDATE Appointments SET AppointmentDate = @Date WHERE AppointmentID = @ID";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@Date", newDate),
                new SqlParameter("@ID", appointmentId));

            if (rows > 0)
            {
                MessageBox.Show("Appointment updated!");
                LoadAppointments();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 0) return;

            int appointmentId = (int)dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value;

            string query = "DELETE FROM Appointments WHERE AppointmentID = @ID";

            int rows = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter("@ID", appointmentId));

            if (rows > 0)
            {
                MessageBox.Show("Appointment deleted!");
                LoadAppointments();
            }
        }
    }
}
