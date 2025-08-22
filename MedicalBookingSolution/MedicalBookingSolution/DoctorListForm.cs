using MedicalBookingApp.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MedicalBookingApp
{
    public partial class DoctorListForm : Form
    {
        public DoctorListForm()
        {
            InitializeComponent();
        }

        // Load all doctors on form load
        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        // Load doctors into grid
        private void LoadDoctors(string search = "")
        {
            string query;

            if (string.IsNullOrWhiteSpace(search))
            {
                query = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors";
                dgvDoctors.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            else
            {
                query = "SELECT DoctorID, FullName, Specialty, Availability FROM Doctors WHERE FullName LIKE @name";
                dgvDoctors.DataSource = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@name", "%" + search + "%")
                );
            }
        }

        // Search button click
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            LoadDoctors(search);
        }
    }
}
