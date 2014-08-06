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
namespace CMS.Web.Region
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
		CMS.BLL.Region bll=new CMS.BLL.Region();
		CMS.Model.Region model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtpid.Text=model.pid.ToString();
		this.txtsort.Text=model.sort.ToString();
		this.txtlevel.Text=model.level.ToString();
		this.txtlongcode.Text=model.longcode;
		this.txtcode.Text=model.code;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpid.Text))
			{
				strErr+="pid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsort.Text))
			{
				strErr+="sort格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlevel.Text))
			{
				strErr+="level格式错误！\\n";	
			}
			if(this.txtlongcode.Text.Trim().Length==0)
			{
				strErr+="longcode不能为空！\\n";	
			}
			if(this.txtcode.Text.Trim().Length==0)
			{
				strErr+="code不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			int pid=int.Parse(this.txtpid.Text);
			int sort=int.Parse(this.txtsort.Text);
			int level=int.Parse(this.txtlevel.Text);
			string longcode=this.txtlongcode.Text;
			string code=this.txtcode.Text;


			CMS.Model.Region model=new CMS.Model.Region();
			model.id=id;
			model.name=name;
			model.pid=pid;
			model.sort=sort;
			model.level=level;
			model.longcode=longcode;
			model.code=code;

			CMS.BLL.Region bll=new CMS.BLL.Region();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
