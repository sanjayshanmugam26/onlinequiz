using System.Data.SqlClient;

namespace onlinequiz.Models
{
    public class scoremanagerBase
    {
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
        public int InsertListIntoDatabase(scoremanager scoremanager)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = db.GetConnection();
            sqlcmd.CommandType = @"INSERT INTO score ([challenger_name],[challenger_score],[created_by],[created_date],[modified_by],[modified_date]) VALUES
                                  (@challenger_name, @challenger_score, @created_by, @created_date, @modified_by, @modified_date)";
        }

        internal void InsertListIntoDatabase(Score_data score)
        {
            throw new NotImplementedException();
        }
    }
}