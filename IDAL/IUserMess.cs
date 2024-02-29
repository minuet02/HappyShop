using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IDAL
{
    public interface IUserMess
    {
        int InsertMess(UserMessInfo mess);
        IList<UserMessInfo> GetUserMess();
    }
}
