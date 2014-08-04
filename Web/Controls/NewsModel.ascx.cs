﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS.Web.Controls
{
    public partial class NewsModel : System.Web.UI.UserControl
    {
        public int CategoryId {set;get;}
        public  string NewsModelName { set; get; }
        private string allCategory = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        #region 绑定数据
        public void BindData()
        {
            ModelName.Text=NewsModelName;
            CMS.BLL.News bll = new CMS.BLL.News();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder("1=1");
            getAllCategory();
            strWhere.AppendFormat(" and category in ({0}) ", allCategory);
            
            string orderby = "id desc ";
            ds = bll.GetListByPage(strWhere.ToString(), orderby, 0, 6);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
        #endregion

        #region 获得当前栏目下的所有栏目
        private void getAllCategory()
        {

            BLL.Category bll = new BLL.Category();
            DataTable table = bll.GetChildren(CategoryId);
            allCategory += CategoryId.ToString() + ",";
            foreach (DataRow row in table.Rows)
            {
                allCategory += row["id"].ToString() + ",";
            }

            allCategory = allCategory.TrimEnd(new char[] { ',' });
        }

        #endregion

    }
}