﻿using System;
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
namespace Maticsoft.Web.Users
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
		Maticsoft.Model.Users model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblUserLoginID.Text=model.UserLoginID;
		this.lblPassword.Text=model.Password;
		this.lblUserName.Text=model.UserName;
		this.lblUserEmail.Text=model.UserEmail;
		this.lblUserRegDate.Text=model.UserRegDate.ToString();
		this.lblUserType.Text=model.UserType;
		this.lblRemark.Text=model.Remark;

	}


    }
}
