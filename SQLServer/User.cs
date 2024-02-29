using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

/// <summary>
/// SQLUser 的摘要说明
/// </summary>
namespace SQLServer
{
    public class User : IUser
    {
        public IList<UserInfo> GetUser()
        {

            IList<UserInfo> userInfo = new List<UserInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectUser", null))
            {

                while (dr.Read())
                {

                    UserInfo user = new UserInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3));
                    userInfo.Add(user);

                }

            }
            return userInfo;
        }
        public IList<UserInfo> GetUserById(int nId)
        {

            IList<UserInfo> userInfo = new List<UserInfo>();
            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.Int, 4) };
            paras[0].Value = nId;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectUserById", paras))
            {
                while (dr.Read())
                {
                    if (dr["Phone"] == null)
                    {
                        UserInfo user = new UserInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), null, dr.GetInt64(5), dr.GetString(6), dr.GetString(7), dr.GetBoolean(8));
                        userInfo.Add(user);
                    }
                    else
                    {

                        UserInfo user = new UserInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt64(5), dr.GetString(6), dr.GetString(7),dr.GetBoolean(8));
                        userInfo.Add(user);

                    }
                }

            }
            return userInfo;

        }
        public IList<UserInfo> GetUserDataByName(string nName)
        {
            IList<UserInfo> userInfo = new List<UserInfo>();
            SqlParameter[] paras = { new SqlParameter("@Name", SqlDbType.VarChar, 30) };
            paras[0].Value = nName;
            string sqlText = "SELECT Name,Email,Phone,Telephone,Adress FROM [User] WHERE Name=@Name";
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, paras))
            {
                while (dr.Read())
                {

                    UserInfo user = new UserInfo(dr.GetString(0),dr.GetString(1),dr.GetString(2),dr.GetInt64(3),dr.GetString(4));
                    userInfo.Add(user);

                }

            }

            return userInfo;
        }
        public bool CheckName(string nName)
        {

            bool IsBool;
            SqlParameter[] paras = { new SqlParameter("@Name", SqlDbType.VarChar, 30) };
            paras[0].Value = nName;
            string sqlText = "SELECT count(*) FROM [User] WHERE Name=@Name";
            try
            {

                int txtRows = int.Parse(SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, paras).ToString());
                if (txtRows > 0)
                {

                    IsBool = true;

                }
                else
                {

                    IsBool = false;

                }
                return IsBool;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }


        }
        public bool CheckUser(string nName, string nPass)
        {

            bool IsBool;
            SqlParameter[] paras = { new SqlParameter("@Name", SqlDbType.VarChar, 30), new SqlParameter("@Pass", SqlDbType.VarChar, 30) };
            paras[0].Value = nName;
            paras[1].Value = nPass;
            string sqlText = "SELECT count(*) FROM [User] WHERE Name=@Name AND Pass=@Pass";
            try
            {

                int txtRows = int.Parse(SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, sqlText, paras).ToString());
                if (txtRows > 0)
                {

                    IsBool = true;

                }
                else
                {

                    IsBool = false;

                }
                return IsBool;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        public int InsertUser(UserInfo nUser)
        {

            int rows;
            SqlParameter[] paras = { new SqlParameter("@Name", SqlDbType.VarChar,30),
                                     new SqlParameter("@Pass", SqlDbType.VarChar,30),
                                     new SqlParameter("@Email", SqlDbType.VarChar,30),
                                     new SqlParameter("@Phone", SqlDbType.VarChar,30),
                                     new SqlParameter("@Telephone", SqlDbType.BigInt,8),
                                     new SqlParameter("@Adress", SqlDbType.NVarChar,50),
                                     new SqlParameter("@IP", SqlDbType.VarChar,30),
            
            };
            paras[0].Value = nUser.UserName;
            paras[1].Value = nUser.UserPass;
            paras[2].Value = nUser.UserEmail;
            paras[3].Value = nUser.UserPhone;
            paras[4].Value = nUser.UserTelephone;
            paras[5].Value = nUser.UserAdress;
            paras[6].Value = nUser.UserIP;
            try
            {

                rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertUserToUser", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
    }
}