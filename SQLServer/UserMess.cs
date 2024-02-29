using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

namespace SQLServer
{
    public class UserMess : IUserMess
    {
        public int InsertMess(UserMessInfo mess) {

            SqlParameter[] parss ={ new SqlParameter("Name", SqlDbType.NVarChar, 30), new SqlParameter("Content", SqlDbType.NVarChar,1000), new SqlParameter("Time", SqlDbType.DateTime, 8) };
            parss[0].Value = mess.Name;
            parss[1].Value = mess.Content;
            parss[2].Value = mess.DateTim;
            try
            {

                int rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertIntoUserMess", parss);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }            
        
        }
        public IList<UserMessInfo> GetUserMess() {

            IList<UserMessInfo> userMess = new List<UserMessInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectUserMess", null)) {

                while (dr.Read()) {

                    UserMessInfo userMe = new UserMessInfo(dr.GetInt32(0),dr.GetString(1), dr.GetString(2), dr.GetDateTime(3).ToString());
                    userMess.Add(userMe);
                
                }
            
            }
            return userMess;
        
        }
    }
}
