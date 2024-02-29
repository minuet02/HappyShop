using System.Collections.Generic;
using IDAL;
using Model;


/// <summary>
/// BLLUser 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 实现商品类别的业务逻辑类
    /// </summary>
    public class User
    {
        private static readonly IUser dal = DALFactory.DataAccess.CreateUser();
        public IList<UserInfo> GetUser()
        {

            return dal.GetUser();

        }
        public IList<UserInfo> GetUserById(int nId)
        {

            if (nId < 0)
                return new List<UserInfo>();

            return dal.GetUserById(nId);

        }
        public IList<UserInfo> GetUserDataByName(string nName)
        {
            if (string.IsNullOrEmpty(nName))
                return new List<UserInfo>();
            return dal.GetUserDataByName(nName);

        }
        public bool CheckName(string nName)
        {

            if (string.IsNullOrEmpty(nName))
                return true;
            return dal.CheckName(nName);

        }
        public bool CheckUser(string nName, string nPass)
        {

            if (string.IsNullOrEmpty(nName) || string.IsNullOrEmpty(nPass))
                return false;
            return dal.CheckUser(nName, nPass);

        }
        public int InsertUser(UserInfo nUser)
        {

            return dal.InsertUser(nUser);

        }
    }
}