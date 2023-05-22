<%@ Page Title="" Language="C#" MasterPageFile="~/master/dhl.Master" AutoEventWireup="true" CodeBehind="btnewsform.aspx.cs" Inherits="Maticsoft.Web.Bt.btnewsform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Btjs/btnewsfo/css/bootstrap.min.css" type="text/css" rel="stylesheet"/>
    <link href="../Btjs/btnewsfo/css/style.css" type="text/css" rel="stylesheet" />
    <link href="../Btjs/btnewsfo/css/swiper-bundle.min.css" type="text/css" rel="stylesheet" />
    <link href="../Btjs/btnewsfo/js/bootstrap.min.js" type="text/javascript" rel="stylesheet" />
    <link href="../Btjs/btnewsfo/js/jquery-3.4.1.min.js" type="text/javascript" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <body>


    <div class="header-bg">
        <img src="images/banner3.jpg" alt="">
        <div class="title">
            BT新闻
        </div>
    </div>

    <div class="content w py-3 contentBlog">
        <div class="content-l">
            <h4 class="mb-3">新闻列表</h4>
            <h4 class="mb-3">
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></h4>
            <div class="card mb-3 box">
                <a id="a" runat="server" onserverclick="a_ServerClick">
                    <div class="row no-gutters">
                        <div class="col-4">
                            <div class="pic">
                                <img src="" class="" alt="">
                            </div>
                        </div>
                        <div class="col-8">
                            <div class="card-body">
                                <h5 class="card-title">
                                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h5>
                                <p class="card-text"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p class="card-text"><small class="text-white"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></small></p>
                            </div>
                        </div>
                    </div>
                </a>
               
            </div>
            <div class="card mb-3 box">
                <a id="aa" runat="server" onserverclick="aa_ServerClick">
                    <div class="row no-gutters">
                        <div class="col-4">
                            <div class="pic">
                                <img src="" class="" alt="">
                            </div>
                        </div>
                        <div class="col-8">
                            <div class="card-body">
                                <h5 class="card-title"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></h5>
                                <p class="card-text"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p class="card-text"><small class="text-white"><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></small></p>
                            </div>
                        </div>
                    </div>
                </a>
               
            </div>
            <div class="card mb-3 box">
                <a id="aaa" runat="server" onserverclick="aaa_ServerClick">
                    
                    <div class="row no-gutters">
                        <div class="col-4">
                            <div class="pic">
                                <img src="" class="" alt="">
                            </div>
                        </div>
                        <div class="col-8">
                            <div class="card-body">
                                <h5 class="card-title"><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></h5>
                                <p class="card-text"><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p class="card-text"><small class="text-white"><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></small></p>
                            </div>
                        </div>
                    </div>
                </a>
               
            </div>

            <nav aria-label="...">
                <ul class="pagination">
                    <li class="page-item">
                            <asp:Button ID="Button1" class="page-link" runat="server" Text="Button" OnClick="Button1_Click" />
                    </li>
                    <li class="page-item"><a class="page-link" href="#">1</a></li>
                    <li class="page-item">
                        <asp:Button ID="Button2" class="page-link" runat="server" Text="Button" OnClick="Button2_Click" />
                    </li>
                </ul>
            </nav>


        </div>
        <div class="content-r">
            <h4 class="mb-3">搜索</h4>
            <div class="search mb-3 row">
                <div class="col-9 pr-0">
                    <input type="text" class="form-control" id="exampleFormControlInput1" placeholder="搜索">
                </div>
                <div class="col-3 ">
                    <button type="button" class="btn btn-dark">搜索</button>
                </div>
            </div>
            <h4 class="mb-3">新闻分类标签</h4>
            <div class="tags mb-3">
                <span class="badge badge-dark">xx新闻</span>
                <span class="badge badge-dark">xx新闻</span>
                <span class="badge badge-dark">xx新闻</span>
                <span class="badge badge-dark">xx新闻</span>
                <span class="badge badge-dark">xx新闻</span>
                <span class="badge badge-dark">xx新闻</span>
            </div>
            <h4 class="mb-3">网站信息</h4>
            <footer class="footer shadow-lg">
                <p>网站提示</p>
                <p><a href="">修改新闻内容</a></p>
                <p><a href="zhongzhuana.aspx">新闻类型管理</a></p>
                <p>
                    <a href="tbnewsrelease.aspx">新闻发布</a>
                    <a href="#">新闻管理</a>
                </p>
            </footer>
        </div>
    </div>
</body>

</asp:Content>
