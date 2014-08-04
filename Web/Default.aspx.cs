using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using tk.tingyuxuan.utils;

namespace CMS.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitSEO();//初始化SEO
            InitAd();//初始化化广告
            InitSwitchPicture();

            #region 项目推荐
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder("recommend=1");
            string orderBy = "addTime desc";
           // CMS.BLL.Project bll = new CMS.BLL.Project();
            //ds= bll.GetTopList(strWhere.ToString(), orderBy, 8);
            RecommendXiangMuRepeater.DataSource = ds;
            RecommendXiangMuRepeater.DataBind();
            #endregion

            #region 企业产权
            strWhere = new StringBuilder("category=64");
           // ds = bll.GetTopList(strWhere.ToString(), orderBy, 6);
            QiYeRepeater.DataSource = ds;
            QiYeRepeater.DataBind();
            #endregion

            #region 成交公示
            strWhere = new StringBuilder("category=69");
            
            CMS.BLL.News newsBll = new CMS.BLL.News();
            ds = newsBll.GetTopList(strWhere.ToString(), orderBy, 8);
            ChengJiaoRepeater.DataSource = ds;
            ChengJiaoRepeater.DataBind();
            #endregion


            #region 重点项目展示
            strWhere = new StringBuilder("recommend=2");
          //  ds = bll.GetTopList(strWhere.ToString(), orderBy, 10);
            ZDXMRepeater.DataSource = ds;
            ZDXMRepeater.DataBind();
            #endregion

            

            #region 固定资产
            strWhere = new StringBuilder("category=65");
           // ds = bll.GetTopList(strWhere.ToString(), orderBy, 6);
            GuDingZiChanRepeater.DataSource = ds;
            GuDingZiChanRepeater.DataBind();
            #endregion

            #region 文档下载
            strWhere = new StringBuilder("category=32");
          //  ds = newsBll.GetTopList(strWhere.ToString(), orderBy, 8);
            XiaZaiRepeater.DataSource = ds;
            XiaZaiRepeater.DataBind();
            #endregion


            #region 涉诉资产
            strWhere = new StringBuilder("category=67");
           // ds = bll.GetTopList(strWhere.ToString(), orderBy, 8);
            SheSuZiChanRepeater.DataSource = ds;
            SheSuZiChanRepeater.DataBind();
            #endregion

            #region 投融资
            strWhere = new StringBuilder("category=66");
           // ds = bll.GetTopList(strWhere.ToString(), orderBy, 6);
            TouRongZiRepeater.DataSource = ds;
            TouRongZiRepeater.DataBind();
            #endregion

            #region 政策法规
            string allCategory = this.getAllCategory(25);
            strWhere = new StringBuilder("category in "+allCategory);
           // ds = newsBll.GetTopList(strWhere.ToString(), orderBy, 8);
            FaGuiRepeater.DataSource = ds;
            FaGuiRepeater.DataBind();
            #endregion

           

            #region 联发专区
            strWhere = new StringBuilder("category=68");
        //    ds = bll.GetTopList(strWhere.ToString(), orderBy, 6);
            LianFaRepeater.DataSource = ds;
            LianFaRepeater.DataBind();
            #endregion

            #region 会员项目
            strWhere = new StringBuilder("isMember=1");
           // ds = bll.GetTopList(strWhere.ToString(), orderBy, 7);
            MemberXiangMuRepeater.DataSource = ds;
            MemberXiangMuRepeater.DataBind();
            #endregion
            

          


        }

        #region 获得当前栏目下的所有栏目
        private string getAllCategory(int CategoryId )
        {
            string allCategory = "(";
            BLL.Category bll = new BLL.Category();
            DataTable table = bll.GetChildren(CategoryId);
            allCategory += CategoryId.ToString() + ",";
            foreach (DataRow row in table.Rows)
            {
                allCategory += row["id"].ToString() + ",";
            }

            allCategory = allCategory.TrimEnd(new char[] { ',' });
            return allCategory+")";
        }

        #endregion

        #region 初始化化广告
        private void InitAd()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.AppendFormat("startTime<'{0}' and endTime>'{0}'", DateTime.Now);
            string orderBy = "id desc";

            CMS.BLL.Advertisement bll = new CMS.BLL.Advertisement();
            ds= bll.GetTopList(strWhere.ToString(), orderBy, 4);

            AdvertisementRepeater.DataSource = ds;
            AdvertisementRepeater.DataBind();

        }
        #endregion
        #region 初始化SEO
        private void InitSEO()
        {

            CMS.Web.Admin.Config.Config config = new CMS.Web.Admin.Config.Config();
            CMS.Model.Config SeoConfig = config.ReadConfig();
            Page.Title = SeoConfig.SiteName;
            Literal Keywords = this.Master.FindControl("SEOKeywords") as Literal;
            Literal Description = this.Master.FindControl("SEODescription") as Literal;
            Keywords.Text = string.Format(@"<meta name=""keyWords"" content=""{0}"" />", tk.tingyuxuan.utils.HtmlHelper.SubStr(SeoConfig.KeyWords, 80, true));

            Description.Text = string.Format(@"<meta name=""description"" content=""{0}"" />", tk.tingyuxuan.utils.HtmlHelper.SubStr(SeoConfig.Description, 80, true));
            Keywords.Text = "\r\n" + Keywords.Text + "\r\n";
            Description.Text += "\r\n";

        }
        #endregion
        #region 幻灯片展示
        private void InitSwitchPicture()
        {
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder("isSwitch=1 and (titleImage<>'' and titleImage is not null)");
            string orderBy = "addTime desc";
            
            CMS.BLL.Article bll = new CMS.BLL.Article();
            //ds = bll.GetListByPage(strWhere.ToString(), orderBy, startIndex, endIndex);
            ds = bll.GetTopList(strWhere.ToString(), orderBy, 6);
           
            SwitchRepeater.DataSource = ds;
            SwitchRepeater.DataBind();
        }
        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text.Trim();
            string password = Password.Text.Trim();
            string vCode = VCode.Text.Trim();
            string strErr = "";
            if (userName == "")
            {
                strErr += "用户名不能为空！\\n";
            }

            if (password == "")
            {
                strErr += "密码不能为空！\\n";
            }


            if (Session["vcode"] == null)
            {
                strErr += "验证码已经过期！\\n";
            }
            else
            {
                if (vCode != Session["vcode"].ToString())
                {
                    strErr += "验证码错误！\\n";
                }
            }

            if (strErr != "")
            {
                //MessageBoxTip.Alert(this, strErr);
                MessageBoxTip.Alert(this, strErr);
                return;
            }
            DataSet ds = new DataSet();
            BLL.User bll = new BLL.User();
            StringBuilder strWhere = new StringBuilder();

            strWhere.AppendFormat("userName= '{0}' and password='{1}'", userName, password);
            ds = bll.GetList(strWhere.ToString());

            int Count = ds.Tables["ds"].Rows.Count;
            if (Count == 0)
            {
                MessageBoxTip.Alert(this, "用户名或密码错误!");

            }
            else
            {
                int id = int.Parse(ds.Tables["ds"].Rows[0]["id"].ToString());
                CMS.Model.User user = bll.GetModel(id);
                if (user.isActive)
                {
                    SetUserNode(user);
                    Session["user"] = user;

                    MessageBoxTip.AlertAndRedirect(this, "登录成功", "/Admin/Index/Index.aspx");
                }
                else
                {
                    MessageBoxTip.Alert(this, "该账户还未通过审核，请通过网站底部电话联系我们！");
                }

                // Response.Write("News/List.aspx");
                // MessageBoxTip.AlertAndRedirect(this,"登录成功", );
            }
        }

        #region 设置用户能访问的结点（地址)
        protected void SetUserNode(CMS.Model.User user)
        {
            CMS.BLL.Role roleBll = new CMS.BLL.Role();
            CMS.Model.Role role = roleBll.GetModel(user.type.Value);
            if (role != null)
            {
                user.realName = role.name;
            }
            else
            {
                if (user.userName == "admin")
                {
                    user.realName = "超级管理员";
                }
            }
            CMS.BLL.Role_Node Role_NodeBll = new CMS.BLL.Role_Node();
            DataSet nodeData = Role_NodeBll.GetList("roleId=" + user.type.Value);
            DataRowCollection rows = nodeData.Tables[0].Rows;
            string ids = "";
            string strWhere = "";
            for (int j = 0; j < rows.Count; j++)
            {
                ids += rows[j]["nodeId"].ToString() + ",";
            }

            if (ids != "")
            {
                ids = ids.Remove(ids.Length - 1);
                strWhere = " id in (" + ids + ")";
            }
            CMS.BLL.Node nodeBll = new CMS.BLL.Node();
            DataSet nodeDataSet = nodeBll.GetList(strWhere);
            List<string> node = new List<string>();
            DataRowCollection nodeRows = nodeDataSet.Tables[0].Rows;
            for (int i = 0; i < nodeRows.Count; i++)
            {
                node.Add(nodeRows[i]["url"].ToString().ToLower());
            }


            user.Node = node;
        }
        #endregion

    }
}