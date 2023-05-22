using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Users
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserLoginID.Text.Trim().Length==0)
			{
				strErr+="UserLoginID不能为空！\\n";	
			}
			if(this.txtPassword.Text.Trim().Length==0)
			{
				strErr+="Password不能为空！\\n";	
			}
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtUserEmail.Text.Trim().Length==0)
			{
				strErr+="UserEmail不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUserRegDate.Text))
			{
				strErr+="UserRegDate格式错误！\\n";	
			}
			if(this.txtUserType.Text.Trim().Length==0)
			{
				strErr+="UserType不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserLoginID=this.txtUserLoginID.Text;
			string Password=this.txtPassword.Text;
			string UserName=this.txtUserName.Text;
			string UserEmail=this.txtUserEmail.Text;
			DateTime UserRegDate=DateTime.Parse(this.txtUserRegDate.Text);
			string UserType=this.txtUserType.Text;
			string Remark=this.txtRemark.Text;

			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
			model.UserLoginID=UserLoginID;
			model.Password=Password;
			model.UserName=UserName;
			model.UserEmail=UserEmail;
			model.UserRegDate=UserRegDate;
			model.UserType=UserType;
			model.Remark=Remark;

			Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
