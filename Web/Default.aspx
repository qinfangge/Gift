<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CMS.Web.Default" %>

<%@ OutputCache Duration="1" VaryByParam="none" %>
<%@ Import Namespace="tk.tingyuxuan.utils" %>
<%@ Register Src="Controls/FriendLinks.ascx" TagName="FriendLinks" TagPrefix="uc1" %>
<%@ Register Src="Controls/NewsModel.ascx" TagName="NewsModel" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageHeader" runat="server">
    <link href="css/lrtk.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="Js/jquery.KinSlideshow-1.2.1.min.js"></script>
    <script type="text/javascript" src="Js/koala.min.1.5.js"></script>
    <script type="text/javascript" src="Js/scroll.js"></script>
    <script type="text/javascript">

        $(function () {
            $("#KinSlideshow").KinSlideshow();

            $("#hotRecommend").Scroll({
                line: 1,
                speed: 600,
                timer: 2000,
                left: "scrollLeft",
                right: "scrollRight",
                flag: "left"
            });

            $("#memberArea a").hover(function () {
                var index = $("#memberArea a").index($(this));
                $(this).addClass("wall").siblings().removeClass();
                $(this).parent().next().find("ul").eq(index).show().siblings().hide();
            }, function () {

            });
        })



    </script>
    <style type="text/css">
        .focus .fcon {
            display: block;
        }
    </style>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Main" runat="server">
    <div class="banner">
        <!-- 代码 开始 -->
        <%if (AdvertisementRepeater.Items.Count > 0)
          { %>
        <div class="focus" id="fsD1">
            <div class="fPic" id="D1pic1">

                <asp:Repeater ID="AdvertisementRepeater" runat="server">
                    <ItemTemplate>

                        <div class="fcon">
                            <a href="<%#Eval("url") %>" target="_blank">
                                <img style="opacity: 1;" src="<%#Eval("image") %>"></a>
                            <%--<span class="shadow"><a href="" target="_blank">红三代叶明子太庙办盛典 白色羽毛装高贵动人</a></span>--%>
                        </div>

                    </ItemTemplate>

                </asp:Repeater>


            </div>
            <div class="fbg">
                <div id="D1fBt" class="D1fBt">
                    <%
              if (AdvertisementRepeater.Items.Count > 1)
              {
                  for (int i = 1; i <= AdvertisementRepeater.Items.Count; i++)
                  {%>

                    <a class="<%=i==1?"current":"" %>" target="_self" hidefocus="true" href="javascript:void(0)"><i>1</i></a>

                    <%
           
                  }
              }%>
                </div>
            </div>
            <span class="prev"></span>
            <span class="next"></span>
        </div>

        <%} %>

        <%if (AdvertisementRepeater.Items.Count > 1)
          {%>
        <script type="text/javascript">
            Qfast.add('widgets', { path: "js/terminator2.2.min.js", type: "js", requires: ['fx'] });
            Qfast(false, 'widgets', function () {
                K.tabs({
                    id: 'fsD1',   //焦点图包裹id  
                    conId: "D1pic1",  //** 大图域包裹id  
                    tabId: "D1fBt",
                    tabTn: "a",
                    conCn: '.fcon', //** 大图域配置class       
                    auto: 1,   //自动播放 1或0
                    effect: 'fade',   //效果配置
                    eType: 'click', //** 鼠标事件
                    pageBt: true,//是否有按钮切换页码
                    bns: ['.prev', '.next'],//** 前后按钮配置class                          
                    interval: 3000  //** 停顿时间  
                })
            })
        </script>
        <%} %>
        <!-- 代码 结束 -->
    </div>

    <div class="abox">
        <div class="fl">
            <div style="visibility: hidden; overflow: hidden; position: relative; float: left; width: 370px; height: 253px;" id="KinSlideshow">

                <asp:Repeater ID="SwitchRepeater" runat="server">
                    <ItemTemplate>


                        <a target="_blank" href="<%#Eval("page") %>Detail.aspx?id=<%#Eval("id") %>">
                            <img width="370" height="253" alt="<%#HtmlHelper.SubStr(Eval("title").ToString(),16,false) %>" src="<%#ImageUtils.GetThumbImagePath(Eval("titleImage").ToString(),370,253,1) %>"></a>

                    </ItemTemplate>
                </asp:Repeater>



            </div>
            <div class="inter_pret">
                <div class="in_tab"><a class="heading-title title-tab">项目推荐</a>  <%--<span class="more">更多&gt;&gt;</span>--%></div>
                <div class="in_cont">
                    <ul>
                        <asp:Repeater ID="RecommendXiangMuRepeater" runat="server">
                            <ItemTemplate>
                                <li>
                                    <a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),23,false) %></a>
                                    <span class="comptime">[<%#Eval("addTime","{0:MM-dd}") %>]</span>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <div style="height: 250px;" class="fr">
            <div class="cs_title"><span>用户登录</span></div>
            <div class="mi_login">
                <form method="post" action="">
                    <div class="padB8">
                        <lable class="padcc">用户名：</lable>

                        <asp:TextBox ID="UserName" CssClass="inputStyle" MaxLength="20" runat="server"></asp:TextBox>


                    </div>
                    <div class="padB8">
                        <lable class="padcc">密码：</lable>

                        <asp:TextBox ID="Password" CssClass="inputStyle" MaxLength="20" runat="server" TextMode="Password"></asp:TextBox>


                    </div>

                    <div class="padB8">
                        <lable class="padcc">验证码：</lable>

                        <asp:TextBox ID="VCode" CssClass="inputStyle" MaxLength="4" Width="63px" runat="server"></asp:TextBox>


                    </div>

                    <div>

                        <img height="40px" style="vertical-align: middle;" src="vcode.aspx" id="vimg" />
                        <a id="refreshVCode" href="javascript:refreshCode();this.blur()">看不清，换一换</a>
                        <script type="text/javascript">
                            function refreshCode() {
                                var vimg = document.getElementById('vimg');
                                vimg.src = vimg.src + "?t=" + new Date();
                            }

                        </script>
                    </div>
                    <%--  <div class="padB8">
                        <lable class="padcc"></lable>
                        <input type="checkbox" name="cbx_keepState" value="true" checked="checked" id="cbx_keepState">
                        <span style="font-size: 12px;">记住登录状态</span>
                    </div>--%>
                    <div class="padB8">
                        <lable class="padcc"></lable>
                        <div class="bottom_an">
                            <asp:Button ID="Button1" CssClass="bottom_yt" runat="server" Text="登 录" OnClick="Button1_Click" />

                            <%--                            <input type="button" disable="true" value="登录" class="bottom_yt" id="btn_Login">--%>
                        </div>
                        <%-- <div class="wjmmbox"><a href="" title="" class="password">忘记密码？</a></div>--%>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <div class="abox as">
        <div class="fl ">
            <div class="top_box"><span class="top_title">企业产权转让挂牌公告</span> <a href="/ProjectList.aspx?category=64&pid=2" target="_blank" class="more">更多&gt;&gt;</a></div>
            <div class="top_count">
                <table cellspacing="0" cellpadding="0" border="1" class="con_tab">
                    <tbody>
                        <tr class="top_count_title">
                            <td>项目编号</td>
                            <td>项目名称</td>
                            <td>挂牌价格(万元)</td>
                            <td>挂牌日期</td>
                            <td>截止日期</td>
                        </tr>

                        <asp:Repeater ID="QiYeRepeater" runat="server">
                            <ItemTemplate>

                                <tr class="<%#(Container.ItemIndex%2==0)?"":"bgcolor"%>">
                                    <td><%#Eval("number") %></td>
                                    <td class=""><a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),20,false) %></a></td>
                                    <td><%#Eval("price") %></td>
                                    <td><%#Eval("startTime","{0:yyyy-MM-dd}") %></td>
                                    <td><%#Eval("endTime","{0:yyyy-MM-dd}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>


                    </tbody>
                </table>

            </div>

        </div>

        <div class="fr as02">
            <div class="cs_title"><span class="pro-tit">成交公示</span> <a href="/NewsList.aspx?category=69" target="_blank" class="more">更多&gt;&gt;</a></div>

            <ul class="cs_count">

                <asp:Repeater ID="ChengJiaoRepeater" runat="server">
                    <ItemTemplate>
                        <li>
                            <a title="<%#Eval("title") %>" target="_blank" href="NewsDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),16,false) %></a>

                        </li>
                    </ItemTemplate>
                </asp:Repeater>

            </ul>

        </div>
    </div>

    <div class="abox as ">
        <div class="conb"><span class="top_title">重点项目展示</span> <%--<span class="more">更多&gt;&gt;</span>--%></div>
        <div class="conb_box">
            <div class="list_goodsTjCon" id="divRecommend">
                <div class="Roll_Left">
                    <a href="javascript:void(0)" name="left" id="scrollLeft">&lt;</a>
                </div>
                <div id="hotRecommend" class="Roll_Con">
                    <ul id="ulRecommend">
                        <asp:Repeater ID="ZDXMRepeater" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="pic">
                                        <a title="<%#Eval("title") %>" target="_blank" href="/ProjectDetail.aspx?id=<%#Eval("id") %>" rel="nofollow">
                                            <img src="<%#ImageUtils.GetThumbImagePath(Eval("titleImage").ToString(),140,150,1) %>" alt="<%#Eval("title") %>"></a>
                                    </div>
                                    <p class="name">
                                        <a title="<%#Eval("title") %>" target="_blank" href="/ProjectDetail.aspx?id=<%#Eval("id") %>"><%#HtmlHelper.SubStr(Eval("title").ToString(),20,false) %></a>
                                    </p>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="Roll_Right">
                    <a href="javascript:void(0)" name="right" id="scrollRight" class="Roll_enabled">&gt;</a>
                </div>
            </div>

        </div>
    </div>

    <div class="abox as">
        <div class="fl ">
            <div class="top_box"><span class="top_title">固定资产转让挂牌公告</span> <a href="/ProjectList.aspx?category=65&pid=2" target="_blank" class="more">更多&gt;&gt;</a></div>
            <div class="top_count">
                <table cellspacing="0" cellpadding="0" border="1" class="con_tab">
                    <tbody>
                        <tr class="top_count_title">
                            <td>项目编号</td>
                            <td>项目名称</td>
                            <td>挂牌价格(万元)</td>
                            <td>挂牌日期</td>
                            <td>截止日期</td>
                        </tr>
                        <asp:Repeater ID="GuDingZiChanRepeater" runat="server">
                            <ItemTemplate>

                                <tr class="<%#(Container.ItemIndex%2==0)?"":"bgcolor"%>">
                                    <td><%#Eval("number") %></td>
                                    <td class=""><a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),20,false) %></a></td>
                                    <td><%#Eval("price") %></td>
                                    <td><%#Eval("startTime","{0:yyyy-MM-dd}") %></td>
                                    <td><%#Eval("endTime","{0:yyyy-MM-dd}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                    </tbody>
                </table>

            </div>

        </div>

        <div class="fr as02">
            <div class="cs_title"><span class="pro-tit">文档下载</span> <a href="/NewsList.aspx?category=32" target="_blank" class="more">更多&gt;&gt;</a></div>

            <ul class="cs_count">

                <asp:Repeater ID="XiaZaiRepeater" runat="server">
                    <ItemTemplate>
                        <li>
                            <a title="<%#Eval("title") %>" target="_blank" href="NewsDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),16,false) %></a>

                        </li>
                    </ItemTemplate>
                </asp:Repeater>


            </ul>

        </div>
    </div>

    <div class="abox as">
        <div class="fl ">
            <div class="top_box"><span class="top_title">涉讼资产交易公告 </span><a href="/ProjectList.aspx?category=67&pid=2" target="_blank" class="more">更多&gt;&gt;</a></div>
            <div class="top_count">
                <table cellspacing="0" cellpadding="0" border="1" class="con_tab">
                    <tbody>
                        <tr class="top_count_title">
                            <td>项目编号</td>
                            <td>项目名称</td>
                            <td>挂牌价格(万元)</td>
                            <td>挂牌日期</td>
                            <td>截止日期</td>
                        </tr>
                        <asp:Repeater ID="SheSuZiChanRepeater" runat="server">
                            <ItemTemplate>

                                <tr class="<%#(Container.ItemIndex%2==0)?"":"bgcolor"%>">
                                    <td><%#Eval("number") %></td>
                                    <td class=""><a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),20,false) %></a></td>
                                    <td><%#Eval("price") %></td>
                                    <td><%#Eval("startTime","{0:yyyy-MM-dd}") %></td>
                                    <td><%#Eval("endTime","{0:yyyy-MM-dd}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                    </tbody>
                </table>

            </div>

        </div>

        <div class="fr as02">
            <div class="cs_title"><span class="pro-tit">市场平台</span> <%--<span class="more">更多&gt;&gt;</span>--%></div>

            <ul class="market">
                <li><a target="_blank" href="/ProjectList.aspx?category=18&pid=2">国资服务平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=20&pid=2">广告交易平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=66&pid=2">投融资服务平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=67&pid=2">涉讼资产处置平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=80&pid=2">文化产权交易平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=24&pid=2">金融资产交易平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=75&pid=2">房地产交易平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=76&pid=2">民营产权交易平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=77&pid=2">招商引资交易平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=78&pid=2">机动车交易平台</a></li>
                <li><a target="_blank" href="http://eedswp.paifun.net/">鄂尔多斯网拍平台</a></li>
                <li><a target="_blank" href="/ProjectList.aspx?category=79&pid=2">其他交易平台</a></li>
            </ul>

        </div>
    </div>

    <div class="abox as">
        <div class="fl ">
            <div class="top_box"><span class="top_title">投资融资项目公告</span> <a href="/ProjectList.aspx?category=21&pid=2" target="_blank" class="more">更多&gt;&gt;</a></div>
            <div class="top_count">
                <table cellspacing="0" cellpadding="0" border="1" class="con_tab">
                    <tbody>
                        <tr class="top_count_title">
                            <td>项目编号</td>
                            <td>项目名称</td>
                            <td>挂牌价格(万元)</td>
                            <td>挂牌日期</td>
                            <td>截止日期</td>
                        </tr>
                        <asp:Repeater ID="TouRongZiRepeater" runat="server">
                            <ItemTemplate>
                                <tr class="<%#(Container.ItemIndex%2==0)?"":"bgcolor"%>">
                                    <td><%#Eval("number") %></td>
                                    <td class=""><a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),20,false) %></a></td>
                                    <td><%#Eval("price") %></td>
                                    <td><%#Eval("startTime","{0:yyyy-MM-dd}") %></td>
                                    <td><%#Eval("endTime","{0:yyyy-MM-dd}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                    </tbody>
                </table>

            </div>

        </div>

        <div class="fr as02">
            <div class="cs_title"><span class="pro-tit">政策法规</span> <a href="/NewsList.aspx?category=25" target="_blank" class="more">更多&gt;&gt;</a></div>

            <ul class="cs_count">

                <asp:Repeater ID="FaGuiRepeater" runat="server">
                    <ItemTemplate>
                        <li>
                            <a title="<%#Eval("title") %>" target="_blank" href="NewsDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),16,false) %></a>

                        </li>
                    </ItemTemplate>
                </asp:Repeater>

            </ul>

        </div>
    </div>

    <div class="abox as ">
        <div class="conb"><span class="top_title">金马甲动态报价大厅</span> <span class="more">更多&gt;&gt;</span></div>
        <div class="conb_box">
            <a target="_blank" href="">
                <img width="959" height="177" alt="" src="images/jmj.jpg"></a>
        </div>
    </div>

    <div class="abox as ">
        <div class="conb"><span class="top_title">竞价项目</span> <span class="more">更多&gt;&gt;</span></div>
        <div class="conb_box">
            <a target="_blank" href="">
                <img width="959" height="341" alt="" src="images/project.jpg"></a>
        </div>
    </div>

    <div class="abox as">
        <div class="fl ">
            <div class="top_box"><span class="top_title">产权交易联发专区</span> <a href="/ProjectList.aspx?category=68&pid=2" target="_blank" class="more">更多&gt;&gt;</a></div>
            <div class="top_count">

                <table cellspacing="0" cellpadding="0" border="1" class="con_tab">
                    <tbody>
                        <tr class="top_count_title">
                            <td>项目编号</td>
                            <td>项目名称</td>
                            <td>挂牌价格(万元)</td>
                            <td>挂牌日期</td>
                            <td>截止日期</td>
                        </tr>
                        <asp:Repeater ID="LianFaRepeater" runat="server">
                            <ItemTemplate>

                                <tr class="<%#(Container.ItemIndex%2==0)?"":"bgcolor"%>">
                                    <td><%#Eval("number") %></td>
                                    <td class=""><a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),20,false) %></a></td>
                                    <td><%#Eval("price") %></td>
                                    <td><%#Eval("startTime","{0:yyyy-MM-dd}") %></td>
                                    <td><%#Eval("endTime","{0:yyyy-MM-dd}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                    </tbody>
                </table>



            </div>
        </div>

        <div class="fr as02">
            <div class="cs_title" id="memberArea"><a class="wall" href="">会员机构</a><a href="">会员机构项目</a></div>
            <div>
                <ul class="market dota">
                    <li><a target="_blank" href="/NewsList.aspx?category=70&pid=26">经纪认证类</a></li>
                    <li><a target="_blank" href="/NewsList.aspx?category=71&pid=26">经纪合作类</a></li>
                    <li><a target="_blank" href="/NewsList.aspx?category=72&pid=26">服务类</a></li>
                    <li><a target="_blank" href="/NewsList.aspx?category=73&pid=26">合作平台</a></li>
                    <li><a target="_blank" href="/NewsList.aspx?category=74&pid=26">媒体联盟</a></li>

                </ul>

                <ul class="cs_count" style="display: none;">
                    <asp:Repeater ID="MemberXiangMuRepeater" runat="server">
                        <ItemTemplate>
                            <li>
                                <a title="<%#Eval("title") %>" target="_blank" href="ProjectDetail.aspx?id=<%#Eval("id") %>" class="complink"><%#HtmlHelper.SubStr(Eval("title").ToString(),16,false) %></a>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>

        </div>
    </div>
    <div class="abox links">
        <span class="LF_left"><b>友情链接</b></span>
        <div class="LF_right">
            <uc1:FriendLinks ID="FriendLinks1" runat="server" />
        </div>
    </div>
</asp:Content>

