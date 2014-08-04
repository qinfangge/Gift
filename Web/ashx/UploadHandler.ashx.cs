using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CMS.Web.ashx
{
    /// <summary>
    /// UploadHandler 的摘要说明
    /// </summary>
    public class UploadHandler : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request["a"];
            switch (action)
            {
                case "add":
                    Upload(context);
                    break;
                case "del":
                    DelateAttachment(context);
                    break;
                default:
                    context.Response.Write("找不到要执行的方法");
                    break;
            }
            
        }

        private void Upload(HttpContext context)
        {
            //接收上传后的文件
            HttpPostedFile file = context.Request.Files["Filedata"];
            //其他参数
            //string somekey = context.Request["someKey"];
            //string other = context.Request["someOtherKey"];
            //获取文件的保存路径
            string path = "/Upload/" + DateTime.Now.ToString("yyyyMMdd") + "/";
            string uploadPath =
                HttpContext.Current.Server.MapPath(path);
            //判断上传的文件是否为空


            if (file != null)
            {
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                //保存文件
                string ext = Path.GetExtension(file.FileName);
                string fileName = System.Guid.NewGuid() + ext;
                string filePath = path + fileName;
                file.SaveAs(uploadPath + fileName);

                //如果上传成功就将文件记录到表中
                CMS.Model.Attachment model = new CMS.Model.Attachment();
                model.path = filePath;
                model.title = fileName;
                model.addTime = DateTime.Now;
                model.fileName = fileName;
                model.size = decimal.Parse(file.ContentLength.ToString());
                model.ext = ext.Substring(1);
                CMS.Model.User user = context.Session["user"] as CMS.Model.User;
                model.userId = user.id;
                CMS.BLL.Attachment bll = new CMS.BLL.Attachment();
                int currentID = bll.Add(model);
                context.Response.Write(currentID);
            }
            else
            {
                context.Response.Write("0");
            }  
        }

        private void DelateAttachment(HttpContext context)
        {
            int id = int.Parse(context.Request["path"].ToString());
            CMS.BLL.Attachment bll = new CMS.BLL.Attachment();
            CMS.Model.Attachment model = bll.GetModel(id);
            if (model != null)
            {
                CMS.Model.User user = context.Session["user"] as CMS.Model.User;
                if (model.userId != user.id)
                {
                    context.Response.Write("不能删除其它人的图片！");
                    return;
                }

                string absolutePath = context.Server.MapPath(model.path);
                if (File.Exists(absolutePath))
                {
                    if (bll.Delete(id))
                    {
                        File.Delete(absolutePath);
                        context.Response.Write("1");
                    }
                    else
                    {
                        context.Response.Write("删除失败，请重试！");
                    }

                }
                else
                {
                    context.Response.Write("1");
                }
            }
            else
            {
                context.Response.Write("1");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}