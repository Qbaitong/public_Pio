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
namespace Maticsoft.Web.Comment
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtNewsID.Text))
			{
				strErr+="NewsID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAuthorID.Text))
			{
				strErr+="AuthorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAdddate.Text))
			{
				strErr+="Adddate格式错误！\\n";	
			}
			if(this.txtContents.Text.Trim().Length==0)
			{
				strErr+="Contents不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
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
			int NewsID=int.Parse(this.txtNewsID.Text);
			int AuthorID=int.Parse(this.txtAuthorID.Text);
			DateTime Adddate=DateTime.Parse(this.txtAdddate.Text);
			string Contents=this.txtContents.Text;
			string Status=this.txtStatus.Text;
			string Remark=this.txtRemark.Text;

			Maticsoft.Model.Comment model=new Maticsoft.Model.Comment();
			model.NewsID=NewsID;
			model.AuthorID=AuthorID;
			model.Adddate=Adddate;
			model.Contents=Contents;
			model.Status=Status;
			model.Remark=Remark;

			Maticsoft.BLL.Comment bll=new Maticsoft.BLL.Comment();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
