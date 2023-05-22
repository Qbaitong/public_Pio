using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            register(TextBox1.Text,TextBox2.Text,TextBox3.Text);
        }
        /// <summary>
        /// 提交的控件按钮
        /// </summary>
        public void register(string name, string possword, string posswords)
        {
            if (possword == posswords)
            {
                new BLL.Users().register(name, possword);
                Response.Write("<script>alert('用户注册成功!');window.location.href='btnewsform.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('用户注册失败!');");
            }
        }
    }
}