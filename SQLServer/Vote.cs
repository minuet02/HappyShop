using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

/// <summary>
/// SQLVote 的摘要说明
/// </summary>
namespace SQLServer
{
    public class Vote : IVote
    {
        public IList<VoteInfo> GetVote()
        {

            string sqlText = "SELECT * FROM Vote";
            IList<VoteInfo> vote = new List<VoteInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, null))
            {

                while (dr.Read())
                {
                    VoteInfo voteInfo = new VoteInfo(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2),dr.GetBoolean(3));
                    vote.Add(voteInfo);
                }

            }
            return vote;
        }
        public int GetVoteTotal()
        {

            string sqlText = "SELECT SUM(VoteNum) FROM Vote";
            try
            {

                object rows = SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, null);
                return int.Parse(rows.ToString());

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        public int UpdateVote(int nId)
        {

            string sqlText = "UPDATE Vote Set VoteNum=VoteNum+1 WHERE Id=@Id";
            SqlParameter[] paras ={ new SqlParameter("@Id", SqlDbType.Int, 4) };
            paras[0].Value = nId;
            try
            {
                int rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
    }
}