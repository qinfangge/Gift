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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace CMS.Web.Coupon
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		CMS.BLL.Coupon bll=new CMS.BLL.Coupon();
		CMS.Model.Coupon model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txttitle.Text=model.title;
		this.txtmoney.Text=model.money.ToString();
		this.txtstartTime.Text=model.startTime.ToString();
		this.txtendTime.Text=model.endTime.ToString();
		this.txtaddTime.Text=model.addTime.ToString();
		this.txttotal.Text=model.total.ToString();
		this.txtisdel.Text=model.isdel.ToString();
		this.txtstatus.Text=model.status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttitle.Text.Trim().Length==0)
			{
				strErr+="title不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtmoney.Text))
			{
				strErr+="优惠券金额格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstartTime.Text))
			{
				strErr+="有效期开始时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtendTime.Text))
			{
				strErr+="有效期结束时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaddTime.Text))
			{
				strErr+="发放时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttotal.Text))
			{
				strErr+="优惠券数量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisdel.Text))
			{
				strErr+="isdel格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstatus.Text))
			{
				strErr+="status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string title=this.txttitle.Text;
			int money=int.Parse(this.txtmoney.Text);
			DateTime startTime=DateTime.Parse(this.txtstartTime.Text);
			DateTime endTime=DateTime.Parse(this.txtendTime.Text);
			DateTime addTime=DateTime.Parse(this.txtaddTime.Text);
			int total=int.Parse(this.txttotal.Text);
			int isdel=int.Parse(this.txtisdel.Text);
			int status=int.Parse(this.txtstatus.Text);


			CMS.Model.Coupon model=new CMS.Model.Coupon();
			model.id=id;
			model.title=title;
			model.money=money;
			model.startTime=startTime;
			model.endTime=endTime;
			model.addTime=addTime;
			model.total=total;
			model.isdel=isdel;
			model.status=status;

			CMS.BLL.Coupon bll=new CMS.BLL.Coupon();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
