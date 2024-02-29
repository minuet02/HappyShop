using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class UserMessInfo
    {
        public int txtId;
        public string txtName = string.Empty;
        public string txtContent = string.Empty;
        public string txtDateTime = string.Empty;
        public UserMessInfo() { }
        public UserMessInfo(int nId,string nName, string nContent, string nDateTime)
        {
            this.txtId = nId;
            this.txtName = nName;
            this.txtContent = nContent;
            this.txtDateTime = nDateTime;
        
        }
        public UserMessInfo(string nName, string nContent, string nDateTime)
        {
            this.txtName = nName;
            this.txtContent = nContent;
            this.txtDateTime = nDateTime;

        }
        public int Id {

            get { return txtId; }
            set { txtId = value; }
        
        }
        public string Name {

            get { return txtName; }
            set { txtName = value; }
        
        }
        public string Content {

            get { return txtContent; }
            set { txtContent = value; }
        
        }
        public string DateTim {

            get { return txtDateTime; }
            set { txtDateTime = value; }
        
        }
    }
}
