using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CMPR.DomainFacultyHelper
{
    public class DomainFacultyRetriever : IDisposable
    {
        private readonly List<object> _objects = new List<object>();
        private SqlConnection _connection;

        public DomainFacultyRetriever()
        {
            _connection =
                new SqlConnection(
                    "Data Source=ABHIMANBHAU-PC;Initial Catalog=CMPRDatabase;User ID=sa;Password=7588884040");
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }

        public IEnumerable<object> GetGuideList(string domain)
        {
            _connection.Open();
            var command = new SqlCommand("SELECT [Faculty Name] FROM [FacultyDomainData] " +
                                         "WHERE Domain1=@domain OR Domain2=@domain OR Domain3=@domain OR Domain4=@domain",
                _connection);
            command.Parameters.AddWithValue("@domain", domain);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                _objects.Add(dr.GetValue(0));
            }
            return _objects;
        }
    }
}