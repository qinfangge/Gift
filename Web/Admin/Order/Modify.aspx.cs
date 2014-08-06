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
namespace CMS.Web.Order
{
    public partial class Modify : Page
    {       

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
		this.txtid.Text=model.id.ToString();
		this.txtorderId.Text=model.orderId;
		this.txtaddTime.Text=model.addTime.ToString();
		this.txtuserId.Text=model.userId.ToString();
		this.txtisDel.Text=model.isDel.ToString();
		this.txtwuliuId.Text=model.wuliuId.ToString();
		this.txtpayId.Text=model.payId.ToString();
		this.txtisPay.Text=model.isPay.ToString();
		this.txtaddressId.Text=model.addressId.ToString();
		this.txtcouponId.Text=model.couponId.ToString();
		this.txtmemo.Text=model.memo;
		this.txttrackingNumber.Text=model.trackingNumber;
		this.txtstate.Text=model.state.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
			if(this.txtorderId.Text.Trim().Length==0)
			{
				strErr+="orderId不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaddTime.Text))
			{
				strErr+="addTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserId.Text))
			{
				strErr+="userId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisDel.Text))
			{
				strErr+="订单是否被删除格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtwuliuId.Text))
			{
				strErr+="配送方式 如韵达 申通格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpayId.Text))
			{
				strErr+="付款方式 如 淘宝、网银格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisPay.Text))
			{
				strErr+="是否已经付款格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtaddressId.Text))
			{
				strErr+="收货地址格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcouponId.Text))
			{
				strErr+="couponId格式错误！\\n";	
			}
			if(this.txtmemo.Text.Trim().Length==0)
			{
				strErr+="memo不能为空！\\n";	
			}
			if(this.txttrackingNumber.Text.Trim().Length==0)
			{
				strErr+="trackingNumber不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtstate.Text))
			{
				strErr+="state格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			string orderId=this.txtorderId.Text;
			DateTime addTime=DateTime.Parse(this.txtaddTime.Text);
			int userId=int.Parse(this.txtuserId.Text);
			int isDel=int.Parse(this.txtisDel.Text);
			int wuliuId=int.Parse(this.txtwuliuId.Text);
			int payId=int.Parse(this.txtpayId.Text);
			int isPay=int.Parse(this.txtisPay.Text);
			int addressId=int.Parse(this.txtaddressId.Text);
			int couponId=int.Parse(this.txtcouponId.Text);
			string memo=this.txtmemo.Text;
			string trackingNumber=this.txttrackingNumber.Text;
			int state=int.Parse(this.txtstate.Text);


			CMS.Model.Order model=new CMS.Model.Order();
			model.id=id;
			model.orderId=orderId;
			model.addTime=addTime;
			model.userId=userId;
			model.isDel=isDel;
			model.wuliuId=wuliuId;
			model.payId=payId;
			model.isPay=isPay;
			model.addressId=addressId;
			model.couponId=couponId;
			model.memo=memo;
			model.trackingNumber=trackingNumber;
			model.state=state;

			CMS.BLL.Order bll=new CMS.BLL.Order();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
