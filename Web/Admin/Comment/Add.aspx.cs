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
namespace CMS.Web.Comment
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcontent.Text.Trim().Length==0)
			{
				strErr+="content不能为空！\\n";	
			}
			if(this.txtreply.Text.Trim().Length==0)
			{
				strErr+="reply不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaddTime.Text))
			{
				strErr+="addTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtobjectId.Text))
			{
				strErr+="objectId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserId.Text))
			{
				strErr+="userId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisdel.Text))
			{
				strErr+="isdel格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttype.Text))
			{
				strErr+="评论的类型 1、产品 2、新闻格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisChecked.Text))
			{
				strErr+="isChecked格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string content=this.txtcontent.Text;
			string reply=this.txtreply.Text;
			DateTime addTime=DateTime.Parse(this.txtaddTime.Text);
			int objectId=int.Parse(this.txtobjectId.Text);
			int userId=int.Parse(this.txtuserId.Text);
			int isdel=int.Parse(this.txtisdel.Text);
			int type=int.Parse(this.txttype.Text);
			int isChecked=int.Parse(this.txtisChecked.Text);

			CMS.Model.Comment model=new CMS.Model.Comment();
			model.content=content;
			model.reply=reply;
			model.addTime=addTime;
			model.objectId=objectId;
			model.userId=userId;
			model.isdel=isdel;
			model.type=type;
			model.isChecked=isChecked;

			CMS.BLL.Comment bll=new CMS.BLL.Comment();
			bll.Add(model);
            tk.tingyuxuan.utils.MessageBoxTip.AlertAndRedirect(this, "保存成功！", "add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }

        protected void txtisdel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
