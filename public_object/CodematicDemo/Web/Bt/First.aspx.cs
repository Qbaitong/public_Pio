using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// 用来初始化session数据，然后实现页面转跳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            csh();
            Response.Redirect("btnewsform.aspx");
        }
        /// <summary>
        /// 用来初始化网页的方法
        /// </summary>
        private void csh()
        {
            //判断用户的登录状态
            Session["state"] = "false";
            //用户的名字
            Session["username"] = "";
            //记录用户是否为管理员
            Session["usertype"] = "false";

            Session["id"] = 0;
            Session["a"] = 0;
            Session["aa"] = 1;
            Session["aaa"] = 2;
        }
    }
}