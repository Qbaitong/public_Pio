<%@ Page Title="" Language="C#" MasterPageFile="~/master/dhl.Master" AutoEventWireup="true" CodeBehind="tbnewsrelease.aspx.cs" Inherits="Maticsoft.Web.Bt.tbnewsrelease" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Btjs/btnewsfo/css/bootstrap.min.css" type="text/css" rel="stylesheet"/>
    <link href="../Btjs/btnewsfo/css/style.css" type="text/css" rel="stylesheet" />
    <link href="../Btjs/btnewsfo/css/swiper-bundle.min.css" type="text/css" rel="stylesheet" />
    <link href="../Btjs/btnewsfo/js/bootstrap.min.js" type="text/javascript" rel="stylesheet" />
    <link href="../Btjs/btnewsfo/js/jquery-3.4.1.min.js" type="text/javascript" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header-bg">

        <img src="images/banner1.jpg" alt="">
        <div class="title">
            新闻发布
        </div>
    </div>


    <div class="content w py-3 contentBlogDetails">
        <div class="content-l">
            <div class="card">
                <img class="card-img-top" src="" alt="">
                <div class="card-body">
                    <p>
                        <span class="text-muted">日期: <asp:Label ID="Label1" runat="server" Text="时间"></asp:Label></span>
                    </p>
                    <h3 class="card-title">新闻内容</h3>
                        <asp:TextBox ID="TextBox3" class="card-text" runat="server" TextMode="MultiLine" Columns="85" rows="25" Text="请编辑您的内容！"></asp:TextBox>
                    <blockquote class="blockquote">
                        <em
                            class="mb-0 blockquote-footer"></em>
                    </blockquote>

                </div>
            </div>

            <h4 class="mb-3">友情提示</h4>
            <div class="card mb-3">
                <div class="row no-gutters">
                    <div class="col-2 userBox">
                        <div class="user">
                            <img src="images/user.png" class="card-img" alt="...">
                        </div>
                    </div>
                    <div class="col-10">
                        <div class="card-body">
                            <h5 class="card-title">请选择新闻标签 <small class="text-muted">不要加空格以及标点，并且只能选择一个标签</small></h5>
                            <p class="card-text">
                                <asp:Label ID="Label2" runat="server" Text=""></asp:Label></p>

                        </div>
                    </div>
                </div>
            </div>
        
            <h4 class="mb-3">发布新闻</h4>
            <form>
                <div class="form-row mb-3">
                    <div class="col">
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="新闻标题"></asp:TextBox>
                    </div>
                    <div class="col">
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="新闻种类"></asp:TextBox>
                    </div>
                    <div class="col">
                        <asp:CheckBox ID="CheckBox1" runat="server" text="是/否开启评论区"/>
                    </div>
                    
                </div>
                <asp:Button ID="Button1" runat="server" type="submit" class="btn " Text="发表" OnClick="Button1_Click" />
            </form> 
    </div>
</asp:Content>
