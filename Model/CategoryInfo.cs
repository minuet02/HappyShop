using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CategoryInfo
    {
        public string txtId = string.Empty;
        public string txtName = string.Empty;
        public string txtDesc = string.Empty;
        public bool txtVis = true;
        public CategoryInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public CategoryInfo(string nId, string nName, string nDesc, bool nVis)
        {
            this.txtId = nId;
            this.txtName = nName;
            this.txtDesc = nDesc;
            this.txtVis = nVis;

        }

        public string CategoryId
        {

            get { return txtId; }
            set { txtId = value; }

        }
        public string CategoryName
        {

            get { return txtName; }
            set { txtName = value; }

        }
        public string Description
        {

            get { return txtDesc; }
            set { txtDesc = value; }

        }
        public bool Vis
        {
            get { return txtVis; }
            set { txtVis = value; }

        }
    }
}