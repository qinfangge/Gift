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
namespace CMS.Web.Favorite
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
		CMS.BLL.Favorite bll=new CMS.BLL.Favorite();
		CMS.Model.Favorite model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserId.Text=model.userId.ToString();
		this.txtproductId.Text=model.productId.ToString();
		this.txtaddTime.Text=model.addTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserId.Text))
			{
				strErr+="userId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtproductId.Text))
			{
				strErr+="productId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaddTime.Text))
			{
				strErr+="addTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int userId=int.Parse(this.txtuserId.Text);
			int productId=int.Parse(this.txtproductId.Text);
			DateTime addTime=DateTime.Parse(this.txtaddTime.Text);


			CMS.Model.Favorite model=new CMS.Model.Favorite();
			model.id=id;
			model.userId=userId;
			model.productId=productId;
			model.addTime=addTime;

			CMS.BLL.Favorite bll=new CMS.BLL.Favorite();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
