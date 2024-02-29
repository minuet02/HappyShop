using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;
//该源码首发自www.51aspx.com(５１aｓｐｘ．ｃｏｍ)

/// <summary>
/// SQLItem 的摘要说明
/// </summary>
namespace SQLServer
{
    public class Item : IItem
    {
        public string GetTitle(int nItemId) {

            SqlParameter[] nParas ={ new SqlParameter("@nId", SqlDbType.Int, 4) };
            nParas[0].Value = nItemId;
            try
            {

                string txtTitle = SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemTitle", nParas).ToString();

                return txtTitle;
            }
            catch (SqlException ex) {
            
                throw new Exception(ex.Message,ex);
            
            }

        }
        public IList<ItemInfo> GetItemByClickTime()
        {
            IList<ItemInfo> item = new List<ItemInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemByClickTime", null))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
        public int UpdateClick(int nId) {

            SqlParameter[] nParas = { new SqlParameter("@Id", SqlDbType.Int, 4) };
            nParas[0].Value = nId;
            try
            {

                int rows = SQLHelper.ExecuteNonQuery(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "UpdateItemClick", nParas);
                return rows;

            }
            catch (SqlException ex) {

                throw new Exception(ex.Message, ex);
            
            }
        
        }
        public IList<ItemInfo> GetItemByNew()
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemByNew", null))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
        public IList<ItemInfo> GetItemByCommend()
        {

            IList<ItemInfo> item = new List<ItemInfo>();

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemByCommend", null))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
        public IList<ItemInfo> GetItemById(int nId)
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            SqlParameter[] nParas = { new SqlParameter("@Id", SqlDbType.Int, 4) };
            nParas[0].Value = nId;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemByID", nParas))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetDecimal(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetInt32(9), dr.GetInt32(10), dr.GetInt32(11), dr.GetString(12), dr.GetString(13), dr.GetString(14), dr.GetBoolean(15));
                    item.Add(itemInfo);
                }
            }
            return item;
        }

        public IList<ItemInfo> GetItemByProduct(string nProductId)
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            SqlParameter[] nParas = { new SqlParameter("@ProductId", SqlDbType.VarChar, 30) };
            nParas[0].Value = nProductId;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemByProductId", nParas))
            {
                while (dr.Read())
                {
                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;
        }
        public IList<ItemInfo> GetItemByCategory(string nCategoryId)
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            SqlParameter[] nParas = { new SqlParameter("@CategoryId", SqlDbType.VarChar, 30) };
            nParas[0].Value = nCategoryId;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemByCategoryId", nParas))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
        public IList<ItemInfo> GetItemByAllCategory(string nCategoryId)
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            SqlParameter[] nParas = { new SqlParameter("@CategoryId", SqlDbType.VarChar, 30) };
            nParas[0].Value = nCategoryId;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectItemAllByCategoryId", nParas))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
        public string GetCategoryName(string nCategoryId)
        {

            string txtCategoryName = string.Empty;
            SqlParameter[] nParas = { new SqlParameter("@CategoryId", SqlDbType.VarChar, 30) };
            nParas[0].Value = nCategoryId;
            string txtSQL = "SELECT Name FROM Category WHERE Id=@CategoryId";
            try
            {

                object txtName = SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, txtSQL, nParas);
                txtCategoryName = txtName.ToString();

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }
            return txtCategoryName;

        }
        public string GetCategoryNameByProductId(string nProductId)
        {

            string txtCategoryName = string.Empty;
            SqlParameter[] nParas = { new SqlParameter("@ProductId", SqlDbType.VarChar, 30) };
            nParas[0].Value = nProductId;
            string txtSQL = "SELECT Category.Name FROM Category INNER JOIN Product ON Category.Id=Product.CategoryId WHERE Product.Id=@ProductId";
            try
            {
                object txtName = SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, txtSQL, nParas);
                txtCategoryName = txtName.ToString();

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }
            return txtCategoryName;

        }
        public string GetCategoryNameByItemId(int nItemId)
        {

            string txtCategoryName = string.Empty;
            SqlParameter[] nParas = { new SqlParameter("@ItemId", SqlDbType.Int, 4) };
            nParas[0].Value = nItemId;
            string txtSQL = "SELECT Category.Name FROM Category INNER JOIN Product ON Category.Id=Product.CategoryId INNER JOIN Item ON Item.ProductId=Product.Id WHERE Item.Id=@ItemId";
            try
            {
                object txtName = SQLHelper.ExecuteSclare(SQLHelper.txtConnecttionString, CommandType.Text, txtSQL, nParas);
                txtCategoryName = txtName.ToString();

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message, ex);

            }
            return txtCategoryName;

        }
        public IList<ItemInfo> SearchItemByCategoryId(string nCaegory, string nItemName)
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            SqlParameter[] nParas = { new SqlParameter("@CategoryId", SqlDbType.VarChar, 30), new SqlParameter("@ItemName", SqlDbType.NVarChar, 50) };
            nParas[0].Value = nCaegory;
            nParas[1].Value = nItemName;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SearchItemByCategoryId", nParas))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
        public IList<ItemInfo> SearchItemByCategoryIdByItem(string nCaegory, string nProduct, decimal nPriceStart, decimal nPriceEnd, string nItemName)
        {

            IList<ItemInfo> item = new List<ItemInfo>();
            SqlParameter[] nParas = { new SqlParameter("@CategoryId", SqlDbType.VarChar, 30), 
                                      new SqlParameter("@ProductId", SqlDbType.VarChar, 30),
                                      new SqlParameter("@PriceStart", SqlDbType.Decimal,9),
                                      new SqlParameter("@PriceEnd", SqlDbType.Decimal,9 ),
                                      new SqlParameter("@ItemName", SqlDbType.NVarChar,50),};
            nParas[0].Value = nCaegory;
            nParas[1].Value = nProduct;
            nParas[2].Value = nPriceStart;
            nParas[3].Value = nPriceEnd;
            nParas[4].Value = nItemName;

            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SearchItemByCategoryIdByProductByItem", nParas))
            {
                while (dr.Read())
                {

                    ItemInfo itemInfo = new ItemInfo(dr.GetInt32(0), dr.GetString(1), dr.GetDecimal(2), dr.GetDecimal(3), dr.GetDecimal(4), dr.GetString(5));
                    item.Add(itemInfo);
                }
            }
            return item;

        }
    }
}