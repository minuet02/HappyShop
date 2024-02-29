using System;
using System.Collections.Generic;
using Model;

/// <summary>
/// IUser 的摘要说明
/// </summary>
namespace IDAL
{
    public interface IUser
    {
        IList<UserInfo> GetUser();
        IList<UserInfo> GetUserById(int nId);
        IList<UserInfo> GetUserDataByName(string nName);
        int InsertUser(UserInfo nUser);
        bool CheckName(string nName);
        bool CheckUser(string nName, string nPass);

    }
}