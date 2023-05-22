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
namespace Maticsoft.Web.NewsCategory
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.NewsCategory bll=new Maticsoft.BLL.NewsCategory();
		Maticsoft.Model.NewsCategory model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtCategoryname.Text=model.Categoryname;
		this.txtStatus.Text=model.Status;
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCategoryname.Text.Trim().Length==0)
			{
				strErr+="新闻名称不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="状态（显示不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="详细说明不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string Categoryname=this.txtCategoryname.Text;
			string Status=this.txtStatus.Text;
			string Remark=this.txtRemark.Text;


			Maticsoft.Model.NewsCategory model=new Maticsoft.Model.NewsCategory();
			model.ID=ID;
			model.Categoryname=Categoryname;
			model.Status=Status;
			model.Remark=Remark;

			Maticsoft.BLL.NewsCategory bll=new Maticsoft.BLL.NewsCategory();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
