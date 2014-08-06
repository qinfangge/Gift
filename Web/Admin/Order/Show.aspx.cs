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
namespace CMS.Web.Order
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		CMS.BLL.Order bll=new CMS.BLL.Order();
		CMS.Model.Order model=bll.GetModel();
		this.lblid.Text=model.id.ToString();
		this.lblorderId.Text=model.orderId;
		this.lbladdTime.Text=model.addTime.ToString();
		this.lbluserId.Text=model.userId.ToString();
		this.lblisDel.Text=model.isDel.ToString();
		this.lblwuliuId.Text=model.wuliuId.ToString();
		this.lblpayId.Text=model.payId.ToString();
		this.lblisPay.Text=model.isPay.ToString();
		this.lbladdressId.Text=model.addressId.ToString();
		this.lblcouponId.Text=model.couponId.ToString();
		this.lblmemo.Text=model.memo;
		this.lbltrackingNumber.Text=model.trackingNumber;
		this.lblstate.Text=model.state.ToString();

	}


    }
}
