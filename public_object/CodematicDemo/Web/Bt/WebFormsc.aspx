<%@ Page Title="" Language="C#" MasterPageFile="~/master/dhl.Master" AutoEventWireup="true" CodeBehind="WebFormsc.aspx.cs" Inherits="Maticsoft.Web.Bt.WebFormsc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="../Btjs/firstjs/first_one.css" type="text/css" rel="stylesheet"/>
	<link href="../Btjs/firstjs/first_two.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<body>
<div class="login-box">
	<h1>登录</h1>
	<div class="input-box">
		<div class="input-text">
			<asp:CheckBox ID="CheckBox1" runat="server" text="是否为管理员"/>
		</div>
	    <div class="input-text">
		    <span class="iconfont icon-mine"></span> 
			<asp:TextBox ID="TextBox1" runat="server"  CssClass="loginuser">用户名</asp:TextBox>
		</div>
		<div class="input-text">
		    <span class="iconfont icon-lock"></span>
			<asp:TextBox ID="TextBox2" runat="server"  CssClass="loginuser">密码</asp:TextBox>
		</div>
		<div class="input-btn">
		<asp:Button ID="Button1" runat="server" Text="登录" BorderStyle="None" OnClick="Button1_Click1" Width="150px" />
		</div>
		<div class="sign-up">
		    还没有账户？<a href="Register.aspx">立即注册</a>
		</div>
	</div>
</div>
</body>
</asp:Content>