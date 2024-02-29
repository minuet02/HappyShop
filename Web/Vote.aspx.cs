using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;
using Model;
public partial class VotePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindVote();
            BindMyVote();
        }
    }
    protected void BindVote() {

        Vote bll = new Vote();
        RepeaterVote.DataSource = bll.GetVote();
        RepeaterVote.DataBind();
    
    }
    protected decimal BindPercert(string nVoteNum) {

        Vote bll = new Vote();
        return int.Parse(nVoteNum) * 100 / bll.GetVoteTotal();
    
    }
    protected void BindMyVote() {

        Vote bll = new Vote();
        MyRadioButtonList.DataSource = bll.GetVote();
        MyRadioButtonList.DataTextField = "VoteName";
        MyRadioButtonList.DataValueField = "VoteId";
        MyRadioButtonList.DataBind();
    
    }
    protected void MyVoteButton_Click(object sender, EventArgs e)
    {
        Vote bll = new Vote();
        foreach (ListItem item in MyRadioButtonList.Items) {

            if (item.Selected == true) {

                bll.UpdateVote(int.Parse(item.Value.ToString()));
            
            }
        
        }
        BindVote();
        Response.Redirect("Vote.aspx");
    }
}
