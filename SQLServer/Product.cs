using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

/// <summary>
/// SQLProduct 的摘要说明
/// </summary>
namespace SQLServer
{
    public class Product : IProduct
    {
        public IList<ProductInfo> GetProduct()
        {

            IList<ProductInfo> product = new List<ProductInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectProduct", null))
            {
                while (dr.Read())
                {
                    ProductInfo productInfo = new ProductInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetBoolean(4));
                    product.Add(productInfo);
                }
            }
            return product;


        }
        public IList<ProductInfo> GetProductById(string nProductId)
        {

            IList<ProductInfo> product = new List<ProductInfo>();
            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar, 30) };
            paras[0].Value = nProductId;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectProductById", paras))
            {
                while (dr.Read())
                {

                    ProductInfo productInfo = new ProductInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetBoolean(4));
                    product.Add(productInfo);
                }
            }
            return product;
        }
        public IList<ProductInfo> GetProductByCategory(string nCategoryId)
        {

            IList<ProductInfo> product = new List<ProductInfo>();
            SqlParameter[] paras = { new SqlParameter("@CategoryId", SqlDbType.VarChar, 30) };
            paras[0].Value = nCategoryId;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectProductByCategoryId", paras))
            {
                while (dr.Read())
                {

                    ProductInfo productInfo = new ProductInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                    product.Add(productInfo);
                }
            }
            return product;
        }
    }
}