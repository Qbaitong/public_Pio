using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Bt
{
    public partial class newstext : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //控件只读
            TextBox3.ReadOnly = true;
            dat();
        }
        public int cz()
        {
            //获取到需要查询的新闻的独立编号
            return Convert.ToInt32(Session["id"]);
        }
        //执行查询的方法，查询到新闻的数据
        public void dat()
        {
            DataSet dt = new BLL.Users().newsTnew(cz());
            Label1.Text = dt.Tables[0].Rows[0][0].ToString();
            Label2.Text = dt.Tables[0].Rows[0][1].ToString();
            Label3.Text = dt.Tables[0].Rows[0][2].ToString();
            TextBox3.Text = dt.Tables[0].Rows[0][3].ToString();
        }

    }
}