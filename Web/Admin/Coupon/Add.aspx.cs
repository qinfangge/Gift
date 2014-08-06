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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string title=this.txttitle.Text;
			int money=int.Parse(this.txtmoney.Text);
			DateTime startTime=DateTime.Parse(this.txtstartTime.Text);
			DateTime endTime=DateTime.Parse(this.txtendTime.Text);
			DateTime addTime=DateTime.Parse(this.txtaddTime.Text);
			int total=int.Parse(this.txttotal.Text);
			int isdel=int.Parse(this.txtisdel.Text);
			int status=int.Parse(this.txtstatus.Text);

			CMS.Model.Coupon model=new CMS.Model.Coupon();
			model.title=title;
			model.money=money;
			model.startTime=startTime;
			model.endTime=endTime;
			model.addTime=addTime;
			model.total=total;
			model.isdel=isdel;
			model.status=status;

			CMS.BLL.Coupon bll=new CMS.BLL.Coupon();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
