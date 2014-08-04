﻿using System;
using System.Web;
using System.Collections;
using System.ComponentModel;
using System.Web.SessionState;
using System.Configuration;
using System.Data;
using System.IO;
using System.Web.Security;
using log4net;
using System.Xml;
//using LTP.Accounts.Bus;
namespace CMS.Web.Admin 
{
	/// <summary>
	/// Global 的摘要说明。
	/// </summary>
	public class Global : System.Web.HttpApplication
	{
        private static readonly ILog logger = LogManager.GetLogger("logger");

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Global()
		{
			InitializeComponent();
		}	
		
		protected void Application_Start(Object sender, EventArgs e)
		{		
           #region 默认蓝
            						
			Application["1xtop1_bgimage"]="images/top-1.gif"; //顶框背景图片
			Application["1xtop2_bgimage"]="images/top-2.gif"; //顶框背景图片
			Application["1xtop3_bgimage"]="images/top-3.gif"; //顶框背景图片
			Application["1xtop4_bgimage"]="images/top-4.gif"; //顶框背景图片
			Application["1xtop5_bgimage"]="images/top-5.gif"; //顶框背景图片
			Application["1xtopbj_bgimage"]="images/top-bj.gif"; //顶框背景图片

			Application["1xtopbar_bgimage"]="images/topbar_01.jpg"; //顶框工具条背景图片
			Application["1xfirstpage_bgimage"]="images/dbsx_01.gif"; //首页背景图片
			Application["1xforumcolor"]="#f0f4fb";
			Application["1xleft_width"]="204"; //左框架宽度
			
			Application["1xtree_bgcolor"]="#e3eeff"; //左框架树背景色
			Application["1xleft1_bgimage"]="images/left-1.gif"; 
			Application["1xleft2_bgimage"]="images/left-2.gif"; 
			Application["1xleft3_bgimage"]="images/left-3.gif"; 
			Application["1xleftbj_bgimage"]="images/left-bj.gif"; 

			Application["1xspliter_color"]="#6B7DDE"; //分隔块色

			Application["1xdesktop_bj"]="";//images/right-bj.gif
			Application["1xdesktop_bgimage"]="images/desktop_01.gif";//right.gif

			Application["1xtable_bgcolor"]="#F5F9FF"; //最外层表格背景
			Application["1xtable_bordercolorlight"]="#4F7FC9"; //中层表格亮边框
			Application["1xtable_bordercolordark"]="#D3D8E0"; //中层表格暗边框
			Application["1xtable_titlebgcolor"]="#E3EFFF"; //中层表格标题栏

			Application["1xform_requestcolor"]="#E78A29"; //表单中必填字段*颜色
			Application["1xfirstpage_topimage"]="images/top_01.gif";
			Application["1xfirstpage_bottomimage"]="images/bottom_01.gif";
			Application["1xfirstpage_middleimage"]="images/bg_01.gif";
			#endregion 		

            log4net.Config.XmlConfigurator.Configure();

		}
 
		protected void Session_Start(Object sender, EventArgs e)
		{
			Session["Style"]=1;
		}
        //protected void Application_BeginRequest(Object sender, EventArgs e)
        //{
        //}

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            /* we guess at this point session is not already retrieved by application so we recreate cookie with the session id... */
            try
            {
                string session_param_name = "ASPSESSID";
                string session_cookie_name = "ASP.NET_SessionId";

                if (HttpContext.Current.Request.Form[session_param_name] != null)
                {
                    UpdateCookie(session_cookie_name, HttpContext.Current.Request.Form[session_param_name]);
                }
                else if (HttpContext.Current.Request.QueryString[session_param_name] != null)
                {
                    UpdateCookie(session_cookie_name, HttpContext.Current.Request.QueryString[session_param_name]);
                }
            }
            catch
            {
            }

            try
            {
                string auth_param_name = "AUTHID";
                string auth_cookie_name = FormsAuthentication.FormsCookieName;

                if (HttpContext.Current.Request.Form[auth_param_name] != null)
                {
                    UpdateCookie(auth_cookie_name, HttpContext.Current.Request.Form[auth_param_name]);
                }
                else if (HttpContext.Current.Request.QueryString[auth_param_name] != null)
                {
                    UpdateCookie(auth_cookie_name, HttpContext.Current.Request.QueryString[auth_param_name]);
                }

            }
            catch
            {
            }
        }

        private void UpdateCookie(string cookie_name, string cookie_value)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies.Get(cookie_name);
            if (null == cookie)
            {
                cookie = new HttpCookie(cookie_name);
            }
            cookie.Value = cookie_value;
            HttpContext.Current.Request.Cookies.Set(cookie);
        }

		protected void Application_EndRequest(Object sender, EventArgs e)
		{
		}
		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{
		}
		protected void Application_Error(Object sender, EventArgs e)
        {

            XmlDocument xDoc = new XmlDocument();
            string file = "~/App_Data/Config.xml";
            xDoc.Load(Server.MapPath(file));
            string isOpen = xDoc.SelectSingleNode("/config/log/isOpen").InnerText;
            if (isOpen == "true")
            {

                #region 网站异常处理
                //获取到HttpUnhandledException异常，这个异常包含一个实际出现的异常
                Exception ex = Server.GetLastError();
                //实际发生的异常
                Exception iex = ex.InnerException;

                string errorMsg = String.Empty;
                string particular = String.Empty;
                if (iex != null)
                {
                    errorMsg = iex.Message;
                    particular = iex.StackTrace;
                }
                else
                {
                    errorMsg = ex.Message;
                    particular = ex.StackTrace;
                }
                HttpContext.Current.Response.Write("来自Global的错误处理<br />");
                HttpContext.Current.Response.Write(errorMsg);
                string logInfo = errorMsg + "\r\n" + particular;
                logger.Debug(logInfo);

                Application["error"] = errorMsg;
                //Server.ClearError();//处理完及时清理异常
                #endregion
            }

        }
		protected void Session_End(Object sender, EventArgs e)
		{		
			
		}
		protected void Application_End(Object sender, EventArgs e)
		{
		}
			
		#region Web 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
