using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

/// <summary>
/// SQLOrder 的摘要说明
/// </summary>
namespace SQLServer
{
    public class Order : IOrder
    {
        public IList<OrderInfo> GetOrder()
        {

            IList<OrderInfo> orderInfo = new List<OrderInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectOrder", null))
            {

                while (dr.Read())
                {

                    OrderInfo order = new OrderInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetDecimal(3), dr.GetInt32(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7), dr.GetString(8), dr.GetInt64(9), dr.GetBoolean(10));
                    orderInfo.Add(order);

                }

            }
            return orderInfo;
        }
        public IList<OrderInfo> GetOrderAndOrderStatus(string nName)
        {

            IList<OrderInfo> orderInfo = new List<OrderInfo>();
            SqlParameter[] paras ={ new SqlParameter("@Name", SqlDbType.VarChar, 30) };
            paras[0].Value = nName;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectOrderAndOrderStatus",paras))
            {

                while (dr.Read())
                {

                    OrderInfo order = new OrderInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetDecimal(3), dr.GetInt32(4),dr.GetBoolean(5),dr.GetBoolean(6),dr.GetInt32(7));
                    orderInfo.Add(order);

                }

            }
            return orderInfo;
        }
        public int InsertOrder(OrderInfo nOrder)
        {

            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar, 50),
                                     new SqlParameter("@UserName",SqlDbType.VarChar,30),
                                     new SqlParameter("@ItemName",SqlDbType.NVarChar,50),
                                     new SqlParameter("@Price",SqlDbType.Decimal,5),
                                     new SqlParameter("@Total",SqlDbType.Decimal,5),

                                     };
            paras[0].Value = nOrder.OrderId;
            paras[1].Value = nOrder.UserName;
            paras[2].Value = nOrder.ItemName;
            paras[3].Value = nOrder.Price;
            paras[4].Value = nOrder.ItemTotal;

            try
            {

                int rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "InsertToOrder", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        public int UpdateDataOrder(OrderInfo nOrder, string nId)
        {

            IList<OrderInfo> orderInfo = new List<OrderInfo>();
            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar,50),
                                     new SqlParameter("@CarryMode", SqlDbType.NVarChar,20),
                                     new SqlParameter("@Adress",SqlDbType.NVarChar,50),
                                     new SqlParameter("@Postalcode",SqlDbType.Int,4),
                                     new SqlParameter("@Phone",SqlDbType.VarChar,30), 
                                     new SqlParameter("@Telephone",SqlDbType.BigInt,8),
                                     };
            paras[0].Value = nOrder.OrderId;
            paras[1].Value = nOrder.CarrayModel;
            paras[2].Value = nOrder.UserAdress;
            paras[3].Value = nOrder.Postalcode;
            paras[4].Value = nOrder.UserPhone;
            paras[5].Value = nOrder.TelePhone;
            try
            {

                int rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "UpdateOrderData", paras);
                return rows;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }

        }
        public int UpdateItemTotal(int nNum, string nId)
        {

            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar,50),
                                     new SqlParameter("@Num", SqlDbType.Int,4)};
            paras[0].Value = nId;
            paras[1].Value = nNum;
            string sqlText = "UPDATE [Order] SET Total=@Num WHERE Id=@Id";
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
        public int DeleteOrder(string nId)
        {

            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar, 50) };
            paras[0].Value = nId;
            string sqlText = "DELETE [Order] WHERE Id=@Id";
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
        public IList<OrderInfo> GetOrderByOneName(string nUserName)
        {

            IList<OrderInfo> orderInfo = new List<OrderInfo>();
            SqlParameter[] paras = { new SqlParameter("@UserName", SqlDbType.VarChar, 30) };
            paras[0].Value = nUserName;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectOrderOneByName", paras))
            {

                while (dr.Read())
                {

                    OrderInfo order = new OrderInfo(dr.GetString(0), dr.GetString(1),dr.GetString(2),dr.GetDecimal(3), dr.GetInt32(4));
                    orderInfo.Add(order);

                }

            }
            return orderInfo;

        }
        public IList<OrderInfo> GetOrderByTwoName(string nId, string nUserName)
        {

            IList<OrderInfo> orderInfo = new List<OrderInfo>();
            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar, 30), new SqlParameter("@UserName", SqlDbType.VarChar, 50) };
            paras[0].Value = nId;
            paras[1].Value = nUserName;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectOrderTwoByName", paras))
            {

                while (dr.Read())
                {

                    OrderInfo order = new OrderInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetDecimal(3), dr.GetInt32(4));
                    orderInfo.Add(order);

                }

            }
            return orderInfo;

        }
    }
}