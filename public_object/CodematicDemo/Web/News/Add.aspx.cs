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
namespace Maticsoft.Web.News
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="Title不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAuthorID.Text))
			{
				strErr+="AuthorID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCategoryID.Text))
			{
				strErr+="CategoryID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddDate.Text))
			{
				strErr+="AddDate格式错误！\\n";	
			}
			if(this.txtReferinfo.Text.Trim().Length==0)
			{
				strErr+="Referinfo不能为空！\\n";	
			}
			if(this.txtContents.Text.Trim().Length==0)
			{
				strErr+="Contents不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
			}
			if(this.txtCommentStatus.Text.Trim().Length==0)
			{
				strErr+="CommentStatus不能为空！\\n";	
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
			string Title=this.txtTitle.Text;
			int AuthorID=int.Parse(this.txtAuthorID.Text);
			int CategoryID=int.Parse(this.txtCategoryID.Text);
			DateTime AddDate=DateTime.Parse(this.txtAddDate.Text);
			string Referinfo=this.txtReferinfo.Text;
			string Contents=this.txtContents.Text;
			string Status=this.txtStatus.Text;
			string CommentStatus=this.txtCommentStatus.Text;
			string Remark=this.txtRemark.Text;

			Maticsoft.Model.News model=new Maticsoft.Model.News();
			model.Title=Title;
			model.AuthorID=AuthorID;
			model.CategoryID=CategoryID;
			model.AddDate=AddDate;
			model.Referinfo=Referinfo;
			model.Contents=Contents;
			model.Status=Status;
			model.CommentStatus=CommentStatus;
			model.Remark=Remark;

			Maticsoft.BLL.News bll=new Maticsoft.BLL.News();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
