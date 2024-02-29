using System.Collections.Generic;
using IDAL;
using Model;

namespace BLL
{
    public class UserMess
    {
        public static readonly IUserMess dal = DALFactory.DataAccess.CreateUserMess();
        public int InsertMess(UserMessInfo mess) {

            return dal.InsertMess(mess);
        
        }
        public IList<UserMessInfo> GetUserMess() {

            return dal.GetUserMess();
        
        }
    }
}
