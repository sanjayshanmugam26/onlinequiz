using System.Data;
using System.Data.SqlClient;

namespace onlinequiz.Models
{
    public class Score_data
    {
        public int challenger_id { get; set; }
        public string? challenger_name { get; set; }
        public string? challenger_score { get; set; }
        public string? createdby { get; set; }
        public DateTime? createddate { get; set; }
        public string? modifiedby { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class scoremanager
    {
        Database db = new Database();
        public List<Score_data> GetList()
        {
            string query = @"select * from scoredetails";
            DataTable dt = db.GetQuery(query);
            List<Score_data> tl = new List<Score_data>();
            foreach (DataRow row in dt.Rows)
            {
                Score_data bl = new Score_data();
                bl.challenger_id = Convert.ToInt32(row["challenger_id"]);
                bl.challenger_name = row["challenger_name"].ToString();
                bl.challenger_score = row["challenger_score"].ToString();
                bl.createdby = row["createdby"].ToString();
                bl.createddate = Convert.ToDateTime(row["createddate"]);
                bl.modifiedby = row["modifiedby"].ToString();
                bl.modifieddate = Convert.ToDateTime(row["modifieddate"]);
                tl.Add(bl);
            }
            return tl;
        }
        //public int GetCount()
        //{
        //    string query = @"Select Max(challenge_id)+1 as challenger_count from score";
        //    DataTable dt = db.GetQuery(query);
        //    int value = 0;
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        value = Convert.ToInt32(row["challenger_count"]);

        //    }
        //    return value;
        //}
        public int InsertListIntoDatabase(Score_data score_Datascore)
        {
            SqlCommand sqlcmd= new SqlCommand();
            sqlcmd.Connection = db.GetConnection();
            sqlcmd.CommandText  = @"INSERT INTO scoredetails ([challenger_name],[challenger_score],[created_by],[created_date],[modified_by],[modified_date]) VALUES
                                  (@challenger_name, @challenger_score, @created_by, @created_date, @modified_by, @modified_date)";
            sqlcmd.Parameters.AddWithValue("@challenger_name", score_Datascore.challenger_name);
            sqlcmd.Parameters.AddWithValue("@challenger_score", score_Datascore.challenger_score);
            sqlcmd.Parameters.AddWithValue("@created_by", score_Datascore.createdby);
            sqlcmd.Parameters.AddWithValue("@created_date", score_Datascore.createddate);
            sqlcmd.Parameters.AddWithValue("@modified_by", score_Datascore.modifiedby);
            sqlcmd.Parameters.AddWithValue("@modified_date", score_Datascore.modifieddate);

            int rowsaffected = sqlcmd.ExecuteNonQuery();

            return rowsaffected;
        }

        
        public List<Score_data> UpdateIntoDatabase()
        {
            return null;
        }
        public List<Score_data> DeleteIntoDatabase()
        {
            return null;
        }

        internal void InsertListIntoDatabase(Score_data score)
        {
            throw new NotImplementedException();
        }
    }
}