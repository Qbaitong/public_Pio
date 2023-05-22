<%@ Page Title="" Language="C#" MasterPageFile="~/master/dhl.Master" AutoEventWireup="true" CodeBehind="Modify_type.aspx.cs" Inherits="Maticsoft.Web.Bt.Modify_type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-box">
	<h1>修改</h1>
	<div>
		<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
	    <asp:Label ID="Label1" runat="server"></asp:Label><br />
		<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></div>
	<asp:Label ID="Label2" runat="server"></asp:Label><br />
	<asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
	<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
