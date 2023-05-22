using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Web.Bt
{
    public partial class Modify_type : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "请输入需要修改的编号，从1到6，最大到6";
            Label2.Text = "请输入需要修改的新闻标题内容";
        }
        /// <summary>
        /// 修改用到的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            judje();
        }
        /// <summary>
        /// 执行判断的方法
        /// </summary>
        /// <returns></returns>
        public void judje()
        {
            bool jua = false;
            int[] ju = {1,2,3,4,5,6,7,8,9};
            for (int i = 0; i < 6; i++)
            {
                if (TextBox1.Text == ju[i].ToString())
                {
                    jua = true;
                }
                else
                { 
                
                }
            }
            if (jua == true)
            {
                modify(Convert.ToInt32(TextBox1.Text),TextBox2.Text);
                Label3.Text = "修改成功";
            }
            else
            {
                Label3.Text = "修改失败";
            }
        }
        /// <summary>
        /// 执行修改的方法，在执行判断的方法中调用
        /// </summary>
        public void modify(int num,string type)
        {
            new BLL.Users().newsmodify(num,type);
        }
    }
}