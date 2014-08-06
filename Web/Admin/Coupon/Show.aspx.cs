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
namespace CMS.Web.Coupon
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
		CMS.BLL.Coupon bll=new CMS.BLL.Coupon();
		CMS.Model.Coupon model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbltitle.Text=model.title;
		this.lblmoney.Text=model.money.ToString();
		this.lblstartTime.Text=model.startTime.ToString();
		this.lblendTime.Text=model.endTime.ToString();
		this.lbladdTime.Text=model.addTime.ToString();
		this.lbltotal.Text=model.total.ToString();
		this.lblisdel.Text=model.isdel.ToString();
		this.lblstatus.Text=model.status.ToString();

	}


    }
}
