using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.master
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Buttonzt.BackColor = Color.Transparent;
            Buttonzt.BorderColor = Color.Transparent;
            Buttonzt.ForeColor = Color.White;
            jiazai();
        }
        protected void Buttonzt_Click1(object sender, EventArgs e)
        {
            if (Session["state"].ToString() == "true")
            {
                Label10.Text = "";
                Label11.Text = "";
                Buttonzt.Text = "登录";
                //判断用户的登录状态
                Session["state"] = "false";
                //用户的名字
                Session["username"] = "";
                //记录用户是否为管理员
                Session["usertype"] = "false";
                load();

                Response.Write("<script>alert('请登录!');</script>");
            }
            else
            {
                Response.Write("<script>alert('请登录!');window.location.href='WebFormsc.aspx';</script>");
            }
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void jiazai()
        {

            DataSet sj = new BLL.Users().newstype();
            Label[] lab = new Label[6];//定义数组控件，有6个元素,并且给label赋值
            lab[0] = Label1;
            lab[1] = Label2;
            lab[2] = Label3;
            lab[3] = Label4;
            lab[4] = Label5;
            lab[5] = Label6;
            for (int i = 0; i < 6; i++)
            {
                lab[i].Text = sj.Tables[0].Rows[i]["newstype"].ToString();
            }
            load();
        }
        /// <summary>
        /// 判断用户是否登录
        /// </summary>
        public void load()
        {
            string lo = Session["state"].ToString();
            if (lo == "true")
            {
                //获取到登录用户的username
                if (Session["usertype"].ToString() == "true")
                {
                    Label11.Text = "管理";
                    Session["usertype"] = "true";
                    Label10.Text = Session["username"].ToString();
                    Buttonzt.Text = "退出登录";
                }
                else
                {
                    Label11.Text = "用户";
                    Label10.Text = Session["username"].ToString();
                    Buttonzt.Text = "退出登录";
                }
            }
            else
            {
                Buttonzt.Text = "登录";
            }
        }
        public void cz()
        {
            Response.Write("<script>alert('退出登录!');window.location.href='WebFormsc.aspx';</script>");
        }
    }
}