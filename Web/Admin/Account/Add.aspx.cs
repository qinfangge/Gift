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
using tk.tingyuxuan.utils;
namespace CMS.Web.Account
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="名称不能为空！\\n";	
			}
			if(this.txtaccount.Text.Trim().Length==0)
			{
				strErr+="帐户不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string name=this.txtname.Text;
			string account=this.txtaccount.Text;

			CMS.Model.Account model=new CMS.Model.Account();
			model.name=name;
			model.account=account;

			CMS.BLL.Account bll=new CMS.BLL.Account();
			bll.Add(model);
            MessageBoxTip.AlertAndRedirect(this, "保存成功！", "add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
