<%@ Page Title="" Language="C#" MasterPageFile="~/master/dhl.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Maticsoft.Web.Bt.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="../Btjs/Register/register1.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="ids">
	请输入用户名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
	<hr />
	密 &nbsp;&nbsp;&nbsp;&nbsp; 码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
	<hr />
密 &nbsp;&nbsp;&nbsp;&nbsp; 码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/><br/>
	<hr />
	<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
		
</div>
</asp:Content>
