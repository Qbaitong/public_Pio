<%@ Page Title="" Language="C#" MasterPageFile="~/master/dhl.Master" AutoEventWireup="true" CodeBehind="newstext.aspx.cs" Inherits="Maticsoft.Web.Bt.newstext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header-bg">

        <img src="images/banner1.jpg" alt="">
        <div class="title">
            新闻浏览
        </div>
    </div>


    <div class="content w py-3 contentBlogDetails">
        <div class="content-l">
            <div class="card">
                <img class="card-img-top" src="" alt="">
                <div class="card-body">
                    <p>
                        <span class="text-muted">发布日期: <asp:Label ID="Label1" runat="server" Text="时间"></asp:Label></span>
                    </p>
                    <p>
                        <span class="text-muted">发布人: <asp:Label ID="Label2" runat="server" Text="时间"></asp:Label></span>
                    </p>
                    <h3 class="card-title"><asp:Label ID="Label3" runat="server" Text="新闻标题"></asp:Label></h3>
                        <asp:TextBox ID="TextBox3" class="card-text" runat="server" TextMode="MultiLine" Columns="85" rows="25" Text="Bt新闻！"></asp:TextBox>
                    <blockquote class="blockquote">
                        <em
                            class="mb-0 blockquote-footer"></em>
                        <asp:Label ID="Label4" runat="server" Text="新闻id"></asp:Label>
                    </blockquote>

                </div>
            </div>

            <h4 class="mb-3">评论区</h4>
            <div class="card mb-3">
                <div class="row no-gutters">
                    <div class="col-2 userBox">
                        <div class="user">
                            <img src="images/user.png" class="card-img" alt="...">
                        </div>
                    </div>
                    <div class="col-10">
                        <div class="card-body">
                            <h5 class="card-title"><small class="text-muted"></small></h5>
                            <p class="card-text">
                                <asp:Label ID="Label9" runat="server" Text="评论区"></asp:Label></p>

                        </div>
                    </div>
                </div>
            </div>
        
           
    </div>
</asp:Content>
