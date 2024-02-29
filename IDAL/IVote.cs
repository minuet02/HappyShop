using System;
using System.Collections.Generic;
using Model;

/// <summary>
/// IVote 的摘要说明
/// </summary>
namespace IDAL
{
    public interface IVote
    {
        IList<VoteInfo> GetVote();
        int UpdateVote(int nId);
        int GetVoteTotal();
    }
}