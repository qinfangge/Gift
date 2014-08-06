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
namespace CMS.Web.Attribute
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
			if(this.txtstyle.Text.Trim().Length==0)
			{
				strErr+="样式不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string name=this.txtname.Text;
			string style=this.txtstyle.Text;

			CMS.Model.Attribute model=new CMS.Model.Attribute();
			model.name=name;
			model.style=style;

			CMS.BLL.Attribute bll=new CMS.BLL.Attribute();
			bll.Add(model);
            tk.tingyuxuan.utils.MessageBoxTip.AlertAndRedirect(this, "保存成功！", "add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
