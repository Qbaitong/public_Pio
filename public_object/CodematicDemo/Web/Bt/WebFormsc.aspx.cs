using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class WebFormsc : System.Web.UI.Page
    {
        //页面加载运行
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Transparent;
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            loading();
        }
        //判断是否为管理员
        public void loading()
        {
            if (CheckBox1.Checked == true)
            {
                denglutow();
            }
            else
            {
                dengluone();
            }
        }
        //用户用来登录的方法
        public void dengluone()
        {
            DataSet dt = new BLL.Users().valer(TextBox1.Text.Trim(), TextBox2.Text.Trim());
            if (dt.Tables[0].Rows.Count > 0)
            {
                Session["username"] = TextBox1.Text;
                Session["state"] = "true";
                Response.Write("<script>alert('用户登录成功!');window.location.href='btnewsform.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('登录失败!');window.location.href='WebFormsc.aspx';</script>");
            }
        }
        public void denglutow()
        {
            DataSet bt = new BLL.Users().Administration(TextBox1.Text.Trim(), TextBox2.Text.Trim());
            if (bt.Tables[0].Rows.Count > 0)
            {
                Session["username"] = TextBox1.Text;
                Session["state"] = "true";
                Session["usertype"] = "true";
                Response.Write("<script>alert('管理员登录成功!');window.location.href='btnewsform.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('管理员登录失败!');window.location.href='WebFormsc.aspx';</script>");
            }
        }
    }
}