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
using System.Text;
namespace CMS.Web.Comment
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		CMS.BLL.Comment bll=new CMS.BLL.Comment();
		CMS.Model.Comment model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblcontent.Text=model.content;
		this.lblreply.Text=model.reply;
		this.lbladdTime.Text=model.addTime.ToString();
		this.lblobjectId.Text=model.objectId.ToString();
		this.lbluserId.Text=model.userId.ToString();
		this.lblisdel.Text=model.isdel.ToString();
		this.lbltype.Text=model.type.ToString();
		this.lblisChecked.Text=model.isChecked.ToString();

	}


    }
}
