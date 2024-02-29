using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Model;
using IDAL;
using DBUnititly;

/// <summary>
/// SQLCategory 的摘要说明
/// </summary>
namespace SQLServer
{
    public class Category : ICategory
    {
        public IList<CategoryInfo> GetCategoryById(string nCategoryId)
        {

            IList<CategoryInfo> categoryInfo = new List<CategoryInfo>();
            SqlParameter[] paras = { new SqlParameter("@Id", SqlDbType.VarChar, 30) };
            paras[0].Value = nCategoryId;
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectCategoryByID", paras))
            {

                while (dr.Read())
                {

                    CategoryInfo category = new CategoryInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3));
                    categoryInfo.Add(category);

                }

            }
            return categoryInfo;
        }

        public IList<CategoryInfo> GetCategory()
        {

            IList<CategoryInfo> categoryInfo = new List<CategoryInfo>();
            using (SqlDataReader dr = SQLHelper.ExecuteReader(SQLHelper.txtConnecttionString, CommandType.StoredProcedure, "SelectCategory", null))
            {

                while (dr.Read())
                {

                    CategoryInfo category = new CategoryInfo(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3));

                    categoryInfo.Add(category);
                }

            }
            return categoryInfo;
        }
    }
}