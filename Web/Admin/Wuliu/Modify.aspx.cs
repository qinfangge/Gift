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
namespace CMS.Web.Wuliu
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
		CMS.BLL.Wuliu bll=new CMS.BLL.Wuliu();
		CMS.Model.Wuliu model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtmoney.Text=model.money.Value.ToString("0.###");
		this.txtmemo.Text=model.memo;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
            if (this.txtname.Text.Trim().Length == 0)
            {
                strErr += "物流名称不能为空！\\n";
            }
            if (!PageValidate.IsDecimal(txtmoney.Text))
            {
                strErr += "费用格式错误！\\n";
            }
            if (this.txtmemo.Text.Trim().Length == 0)
            {
                strErr += "备注不能为空！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			decimal money=decimal.Parse(this.txtmoney.Text);
			string memo=this.txtmemo.Text;


			CMS.Model.Wuliu model=new CMS.Model.Wuliu();
			model.id=id;
			model.name=name;
			model.money=money;
			model.memo=memo;

			CMS.BLL.Wuliu bll=new CMS.BLL.Wuliu();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
