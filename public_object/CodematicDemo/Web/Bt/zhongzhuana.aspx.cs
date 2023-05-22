using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class zhongzhuana : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user();
        }
        /// <summary>
        /// 判断用户是否登录，否，转跳登录，是，判断用户是否为管理，是，转跳管理，否，转跳首页
        /// </summary>
        public void user()
        {
            string lo = Session["state"].ToString();
            if (lo == "true")
            {
                if (Session["usertype"].ToString() == "true")
                {
                    Response.Write("<script>window.location.href='Modify_type.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('您不是管理!');window.location.href='btnewsform.aspx';</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请登录!');window.location.href='WebFormsc.aspx';</script>");
            }
        }
    }
}