using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace MedicalBookingApp.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["MedicalDB"].ConnectionString;

        /// <summary>
        /// Executes a SELECT query and returns results as a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Database query error: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Executes INSERT, UPDATE, or DELETE commands and returns affected row count.
        /// </summary>
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Database non-query error: " + ex.Message, ex);
            }
        }
    }
}
