using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class btnewsform : System.Web.UI.Page
    {
        //计数器
        private int s = 0;
        //
        protected void Page_Load(object sender, EventArgs e)
        {
            statesql();
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            //上一页
            statsql_previous();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //下一页
            stqtsql_next();
        }


        //查询新闻id，新闻标题，发布人，发布时间,赋值给盒子
        public void state()
        {
            DataSet dt = new BLL.Users().newsTnews();
            //获取data中的元素总数
            int s = dt.Tables[0].Rows.Count;
        }
        /// <summary>
        /// 获取开始的新闻，然后可以查阅后面的新闻
        /// </summary>
        public void statesql()
        {
            DataSet dt = new BLL.Users().newsTnews();
            s = dt.Tables[0].Rows.Count;
            Label10.Text = "数据总数：" + s.ToString();
            int aaas = Convert.ToInt32(Session["a"]);
            int aaaas = Convert.ToInt32(Session["aa"]);
            int aaaaas = Convert.ToInt32(Session["aaa"]);
            l(dt.Tables[0].Rows[aaas][2].ToString(), dt.Tables[0].Rows[aaas][1].ToString(), dt.Tables[0].Rows[aaas][3].ToString());
            ll(dt.Tables[0].Rows[aaaas][2].ToString(), dt.Tables[0].Rows[aaaas][1].ToString(), dt.Tables[0].Rows[aaaas][3].ToString());
            lll(dt.Tables[0].Rows[aaaaas][2].ToString(), dt.Tables[0].Rows[aaaaas][1].ToString(), dt.Tables[0].Rows[aaaaas][3].ToString());
        }
        /// <summary>
        /// 上一页
        /// </summary>
        public void statsql_previous()
        {
            if (0 < Convert.ToInt32(Session["a"]))
            {
                Session["a"] = Convert.ToInt32(Session["a"]) - 1;
                Session["aa"] = Convert.ToInt32(Session["aa"]) - 1;
                Session["aaa"] = Convert.ToInt32(Session["aaa"]) - 1;
            }
            statesql();
        }
        /// <summary>
        /// 下一页
        /// </summary>
        public void stqtsql_next()
        {
            if (s - 1 >  Convert.ToInt32(Session["aaa"]))
            {
                Session["a"] = Convert.ToInt32(Session["a"]) + 1;
                Session["aa"] = Convert.ToInt32(Session["aa"]) + 1;
                Session["aaa"] = Convert.ToInt32(Session["aaa"]) + 1;
                statesql();
            }
            statesql();
        }
    
        //label方法注入数据
        public void l(string a,string b,string c)
        {
            Label1.Text = a;
            Label2.Text = b;
            Label3.Text = c;
        }
        public void ll(string a, string b, string c)
        {
            Label4.Text = a;
            Label5.Text = b;
            Label6.Text = c;
        }
        public void lll(string a, string b, string c)
        {
            Label7.Text = a;
            Label8.Text = b;
            Label9.Text = c;
        }
        //labal方法清除数据
        public void la()
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
        }
        public void lal()
        {
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
        }
        public void lall()
        {
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
        }

        protected void a_ServerClick(object sender, EventArgs e)
        {
            id("a");
            Response.Redirect("newstext.aspx?");
        }
        protected void aa_ServerClick(object sender, EventArgs e)
        {
            id("aa");
            Response.Redirect("newstext.aspx?");
        }
        protected void aaa_ServerClick(object sender, EventArgs e)
        {
            id("aaa");
            Response.Redirect("newstext.aspx?");
        }
        //查询id的方法
        public void id(string a)
        {
            DataSet dt = new BLL.Users().newsTnews();
            Label10.Text = "数据总数：" + s.ToString();
            Session["id"] = dt.Tables[0].Rows[Convert.ToInt32(Session["" + a + ""])][0].ToString();
        }
    }
}