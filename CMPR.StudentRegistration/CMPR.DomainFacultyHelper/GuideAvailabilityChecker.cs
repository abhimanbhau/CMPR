using System;
using System.Data.SqlClient;

namespace CMPR.DomainFacultyHelper
{
    public class GuideAvailabilityChecker
    {
        private const String ConnectionString =
            "Data Source=ABHIMANBHAU-PC;Initial Catalog=CMPRDatabase;User ID=sa;Password=7588884040";

        public int GetMaxNumberOfProjectsForGuide(string name)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT [NumberOfMaxProjects] FROM " +
                                                        "[FacultyDomainData] WHERE [Faculty Name]=@name", connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            return Convert.ToInt32(dr[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public int GetCurrentlyAllotedProjects(string name)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT [AllottedProjects] FROM" +
                                                        " [FacultyDomainData] WHERE [Faculty Name]=@name", connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        SqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            return Convert.ToInt32(dr[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }
    }
}