using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ProductInfo
    {
        public string txtId = string.Empty;
        public string txtCategoryId = string.Empty;
        public string txtName = string.Empty;
        public string txtDesc = string.Empty;
        public bool txtVis;
        public ProductInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public ProductInfo(string nId, string nCategoryId, string nName, string nDesc, bool nVis)
        {

            this.txtId = nId;
            this.txtCategoryId = nCategoryId;
            this.txtName = nName;
            this.txtDesc = nDesc;
            this.txtVis = nVis;

        }
        public ProductInfo(string nId, string nCategoryId, string nName)
        {

            this.txtId = nId;
            this.txtCategoryId = nCategoryId;
            this.txtName = nName;

        }
        public string ProductId
        {

            get { return txtId; }
            set { txtId = value; }

        }
        public string CategoryId
        {

            get { return txtCategoryId; }
            set { txtCategoryId = value; }

        }
        public string ProductName
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