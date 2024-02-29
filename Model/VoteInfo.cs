using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class VoteInfo
    {
        public int txtId;
        public string txtName = string.Empty;
        public int txtVoteNum;
        public bool txtVis;
        public VoteInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public VoteInfo(int nId, string nName, int nVoteNum, bool nVis)
        {

            this.txtId = nId;
            this.txtName = nName;
            this.txtVoteNum = nVoteNum;
            this.txtVis = nVis;

        }
        public int VoteId
        {

            get { return txtId; }
            set { txtId = value; }

        }
        public string VoteName
        {

            get { return txtName; }
            set { txtName = value; }

        }
        public int VoteNum
        {

            get { return txtVoteNum; }
            set { txtVoteNum = value; }

        }
        public bool Vis
        {

            get { return txtVis; }
            set { txtVis = value; }

        }
    }
}