using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

/// <summary>
/// SQLOrderStatus 的摘要说明
/// </summary>
namespace SQLServer
{
    public class OrderStatus : IOrderStatus
    {
        public IList<OrderStatusInfo> GetOrderStatus(int nOrderId)
        {

            IList<OrderStatusInfo> orderStatusInfo = new List<OrderStatusInfo>();
            SqlParameter[] paras = { new SqlParameter("@OrderId", SqlDbType.VarChar, 30) };
            paras[0].Value = nOrderId;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectOrderStatus", paras))
            {

                while (dr.Read())
                {

                    OrderStatusInfo orderStatus = new OrderStatusInfo(dr.GetInt32(0), dr.GetInt32(1), dr.GetBoolean(2), dr.GetBoolean(3), dr.GetInt32(4));
                    orderStatusInfo.Add(orderStatus);

                }

            }
            return orderStatusInfo;
        }
    }
}