using System.Collections.Generic;
using IDAL;
using Model;


/// <summary>
/// BLLVote 的摘要说明
/// </summary>
namespace BLL
{
    /// <summary>
    /// 实现商品类别的业务逻辑类
    /// </summary>
    public class Vote
    {
        private static readonly IVote dal = DALFactory.DataAccess.CreateVote();

        public IList<VoteInfo> GetVote()
        {

            return dal.GetVote();

        }
        public int UpdateVote(int nId)
        {

            if (nId < 0)
                return 0;
            return dal.UpdateVote(nId);

        }
        public int GetVoteTotal()
        {

            return dal.GetVoteTotal();

        }
    }
}