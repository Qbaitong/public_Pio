using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class tbnewsrelease : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ty();
        }
        /// <summary>
        /// 提交新闻的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            load();
        }
        /// <summary>
        /// 判断用户是否登录
        /// 通过session获取用户user，发布状态判断，用户false，管理设置为ture
        /// 获取当前时间，判断是否选择新闻类型
        /// 是否允许评论 （char）
        /// </summary>
        public void load()
        {
            if ("true" == Session["state"].ToString())
            {
                TimeAndType();
            }
            else
            {
                //弹出窗口，请登录
                Response.Write("<script>alert('请登录!');</script>");
            }
        }
        /// <summary>
        /// 判断新闻类型是否合格
        /// </summary>
        public void TimeAndType()
        {

            string[] str = type();
            for (int i = 0; i < 6; i++)
            {
                if (str[i].Trim() == TextBox2.Text)
                {
                    Response.Write("<script>alert('" + str[i] + "');</script>");
                    users();
                    return;
                }
                else
                {

                }
            }
            Response.Write("<script>alert('请输入正确的新闻类别！');</script>");
        }
        /// <summary>
        /// 判断是否开启评论区
        /// </summary>
        public string comment()
        {
            string str = "false";
            if (true == CheckBox1.Checked)
            {
                //开启评论区
                Response.Write("<script>alert('开启评论区。');</script>");
                str = "true";
                return str;
            }
            else
            {
                //关闭评论区
                Response.Write("<script>alert('关闭评论区。');</script>");
                return str;
            }
        }

        public void users()
        {
            string users = Session["username"].ToString();
            if ("true" == Session["usertype"].ToString())
            {
                //提示直接提交
                Response.Write("<script>alert('已提交！');</script>");
            }
            else
            {
                //提示等待审核
                Response.Write("<script>alert('请耐性等待审核！');</script>");
            }
            cs();
        }

        /// <summary>
        /// 获取到当前的新闻种类
        /// </summary>
        /// <returns></returns>
        public string[] type()
        {
            string[] types = new string[6];
            DataSet sj = new BLL.Users().newstype();
            for (int i = 0; i < 6; i++)
            {
                types[i] = sj.Tables[0].Rows[i]["newstype"].ToString();
            }
            return types;
        }
        /// <summary>
        /// 将获取到的新闻种类转换为string类型，并且对labal1赋值
        /// </summary>
        /// <returns></returns>
        public void ty()
        {
            string typo = "";
            string[] ypoi = type();
            for (int i = 0; i < 6; i++)
            {
                typo = typo + ypoi[i];
            }
            Label2.Text = typo;
        }



        /// <summary>
        /// 用来执行数据传输的方法
        /// 保存新闻，到数据库中
        /// </summary>
        public void cs()
        {
            new BLL.Users().newssubmit(types(), Session["username"].ToString(),TextBox1.Text, Session["usertype"].ToString(),comment(),TextBox3.Text); 
        }
        public int types()
        {
            int a = 0;
            string[] str = type();
            for (int i = 0; i < 6; i++)
            {
                if (str[i].Trim() == TextBox2.Text)
                {
                    a = i;
                }
                else
                {

                }
            }
            return a;
        }
    }
}