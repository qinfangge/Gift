﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
namespace CMS.Web.Admin.GuestBook
{
    public partial class List : CommonPage
    {
        
        
        
		CMS.BLL.GuestBook bll = new CMS.BLL.GuestBook();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridView.BorderColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_bordercolorlight"].ToString());
                gridView.HeaderStyle.BackColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_titlebgcolor"].ToString());
                btnDelete.Attributes.Add("onclick", "return confirm(\"你确认要删除吗？\")");
                BindData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string url = this.Request.FilePath + "?";

            if (!string.IsNullOrEmpty(txtKeyword.Text))
            {
                url += "keywords=" + txtKeyword.Text;
            }

            Response.Redirect(url, true);

        }
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idlist = GetSelIDlist();
            if (idlist.Trim().Length == 0) 
                return;
            bll.DeleteList(idlist);
            BindData();
        }

        #region gridView

        public void BindData()
        {
            #region
            //if (!Context.User.Identity.IsAuthenticated)
            //{
            //    return;
            //}
            //AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            //if (user.HasPermissionID(PermId_Modify))
            //{
            //    gridView.Columns[6].Visible = true;
            //}
            //if (user.HasPermissionID(PermId_Delete))
            //{
            //    gridView.Columns[7].Visible = true;
            //}
            #endregion

            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if (!string.IsNullOrEmpty(Request["keyWords"]))
            {

                txtKeyword.Text = Request["keyWords"].ToString();
            }

            if (txtKeyword.Text.Trim() != "")
            {
#warning 代码生成警告：请修改 keywordField 为需要匹配查询的真实字段名称
                strWhere.AppendFormat("title like '%{0}%'", txtKeyword.Text.Trim());
            }
            string orderBy = "id desc";
            int currentPage = 1;
            if (!string.IsNullOrEmpty(Request["page"]))
            {
                currentPage = int.Parse(Request["page"].ToString());
            }
            int pageSize = Pager1.PageSize;
            int startIndex = (currentPage - 1) * pageSize + 1;
            int endIndex = currentPage * pageSize;
            //ds = bll.GetListByPage(strWhere.ToString(), orderBy, startIndex, endIndex);
            ds = bll.GetListByPage(strWhere.ToString(), orderBy, pageSize, currentPage, true);
            Pager1.RecordCount = bll.GetRecordCount(strWhere.ToString());
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                btnDelete.Visible = false;
                dt.Rows.Add(dt.NewRow());
                gridView.DataSource = ds;
                gridView.DataBind();
                gridView.Rows[0].Cells.Clear();
                gridView.Rows[0].Cells.Add(new TableCell());
                gridView.Rows[0].Cells[0].ColumnSpan = 8;
                gridView.Rows[0].Cells[0].Text = "暂无信息！";
                gridView.Rows[0].Cells[0].Style.Add("color", "red");
            }
            else
            {
                gridView.DataSource = ds;
                gridView.DataBind();
            }
        }

        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            BindData();
        }
        protected void gridView_OnRowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "<label><input id='checkAll' type='checkbox'/>全选</label>";
            }
        }
        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("style", "background:#FFF");
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
                linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");

                //object obj1 = DataBinder.Eval(e.Row.DataItem, "Levels");
                //if ((obj1 != null) && ((obj1.ToString() != "")))
                //{
                //    e.Row.Cells[1].Text = obj1.ToString();
                //}

                if (e.Row.Cells[5].Text == "True")
                {
                    e.Row.Cells[5].Text = "是";
                }

                if (e.Row.Cells[5].Text.ToString() == "False")
                {
                    e.Row.Cells[5].Text = "否";
                }


            }
        }

        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            int ID = (int)gridView.DataKeys[e.RowIndex].Value;
            bll.Delete(ID);

            BindData();
        }

        private string GetSelIDlist()
        {
            string idlist = "";
            bool BxsChkd = false;
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                CheckBox ChkBxItem = (CheckBox)gridView.Rows[i].FindControl("DeleteThis");
                if (ChkBxItem != null && ChkBxItem.Checked)
                {
                    BxsChkd = true;
                    //#warning 代码生成警告：请检查确认Cells的列索引是否正确
                    if (gridView.DataKeys[i].Value != null)
                    {
                        idlist += gridView.DataKeys[i].Value.ToString() + ",";
                    }
                }
            }
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            return idlist;
        }

        #endregion





    }
}
