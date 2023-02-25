using System.Data;
using System.Data.SqlClient;

namespace onlinequiz.Models
{
    public class Database
    {
        private SqlConnection _sqlConn;



        public Database()
        {
            _sqlConn = new SqlConnection();
        }



        public SqlConnection GetConnection(String ConnectionName = "")
        {



            if (_sqlConn.State != System.Data.ConnectionState.Open)
            {
                IConfigurationBuilder builder = new ConfigurationBuilder();
                builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));



                var root = builder.Build();
                var sampleConnectionString = root.GetConnectionString("MyConnection");
                //string localDB = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
                //// Server Database Connection
                //string serverDB = ConfigurationManager.ConnectionStrings["ServerDB"].ConnectionString;
                _sqlConn.ConnectionString = sampleConnectionString;
                // _sqlConn.ConnectionString = localDB;
                try
                {
                    _sqlConn.Open();



                }



                catch (Exception EX)
                {



                    if (EX is SqlException)
                    {



                    }
                }



            }
            return _sqlConn;
        }



        public void CloseConnection()
        {
            _sqlConn.Close();
        }



        public DataTable GetQuery(String query, List<SqlParameter> paramList = null)
        {
            using (SqlCommand sqlCmd = new SqlCommand())
            {
                sqlCmd.Connection = GetConnection();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query; 
                if (paramList != null)
                {
                    foreach (SqlParameter p in paramList)
                    {
                        sqlCmd.Parameters.Add(p);
                    }
                }
                using (DataTable dt = new DataTable())
                {
                    using (SqlDataAdapter sqlDA = new SqlDataAdapter())
                    {
                        sqlDA.SelectCommand = sqlCmd;
                        sqlDA.Fill(dt);
                        CloseConnection();
                        return dt;
                    }
                }
            }
        }



        public object GetValue(String query, List<SqlParameter> paramList = null)
        {
            using (SqlCommand sqlCmd = new SqlCommand())
            {
                sqlCmd.Connection = GetConnection();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = query;
                if (paramList != null)
                {
                    foreach (SqlParameter p in paramList)
                    {
                        sqlCmd.Parameters.Add(p);
                    }
                }



                return sqlCmd.ExecuteScalar();
            }
        }
        public int GetNextValue(string TableName, string ColumnName)
        {
            DataTable dt = GetQuery("EXECUTE getNextValue N'" + TableName + "', N'" + ColumnName + "'");
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return (int)row["NextValue"];
            }
            else
            {
                return 1;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Database database &&
                   EqualityComparer<SqlConnection>.Default.Equals(_sqlConn, database._sqlConn);
        }
    }

    public enum RecordStatus { Active = 0, Deleted = 1, Archived = 2 };
}