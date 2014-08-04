<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="CMS.Web.Admin.Product.Add" Title="添加信息" %>

<%@ Register Src="../../Controls/Category.ascx" TagName="Category" TagPrefix="uc1" %>

<%@ Register src="../Controls/UploadPic.ascx" tagname="UploadPic" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
    <script type="text/javascript" src="/Js/jquery-1.6.1.min.js"></script>
    <script type="text/javascript" src="/Js/libs/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript" src="/Js/base64.js"></script>
    <!-- 配置文件 -->
    
   
    <script type="text/javascript" src="../js/libs/ueditor/ueditor.config.js"></script>
    <!-- 编辑器源码文件 -->
    <script type="text/javascript" src="../js/libs/ueditor/ueditor.all.js"></script>
    <!-- 语言包文件(建议手动加在语言，避免在ie下有时因为加载语言失败导致编辑器加载失败) -->
    <script type="text/javascript" src="../js/libs/ueditor/lang/zh-cn/zh-cn.js"></script>
    <script type="text/javascript" src="../js/libs/ueditor/ueditor.custom.config.js"></script>
    <script type="text/javascript">

        var editor = UE.getEditor('<%=txtcontent.ClientID%>');
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MinNav" runat="server">
    添加信息
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formView">
        <table cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td style="width: 8em;">标题
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>价格
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="Price" CssClass="date" runat="server"></asp:TextBox>
                    促销价：<asp:TextBox ID="SalePrice" CssClass="date" runat="server"></asp:TextBox>
                    库存:<asp:TextBox ID="Number" CssClass="date" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>类别
	：</td>
                <td class="textWrapper">
                    <uc1:Category ID="Category1" runat="server" ParentId="1" />
                </td>
            </tr>
            <tr>
                <td>推荐到
	：</td>
                <td class="textWrapper">
                    <asp:DropDownList ID="txtrecommend" runat="server">
                        <asp:ListItem Value="0">请选择</asp:ListItem>
                        <asp:ListItem Value="1">1级置顶</asp:ListItem>
                        <asp:ListItem Value="2">2级置顶</asp:ListItem>
                        <asp:ListItem Value="3">3级置顶</asp:ListItem>
                        <asp:ListItem Value="4">4级置顶</asp:ListItem>
                        <asp:ListItem Value="5">5级置顶</asp:ListItem>
                        <asp:ListItem Value="6">6级置顶</asp:ListItem>
                    </asp:DropDownList>
                    <span class="tip">越大越靠前！(6 最大)</span>

                </td>
            </tr>
            <tr>
                <td>幻灯片显示
	：</td>
                <td class="checkBoxWrapper">
                    <asp:CheckBox ID="IsSwitch" runat="server" />
                </td>
            </tr>

            <tr>
                <td>产品图片
	：</td>
                <td class="checkBoxWrapper">


                   
                        <%--用来作为文件队列区域--%>

                       
                        <asp:HiddenField ID="TitleImage" runat="server" />

                       
                        <uc2:UploadPic ID="UploadPic1" runat="server" />

                </td>
            </tr>


            <tr>
                <td>内容
	：</td>
                <td>
                    <asp:TextBox ID="txtcontent" CssClass="richText" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>关键词
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="txtkeywords" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>描述
	：</td>
                <td class="richText">
                    <asp:TextBox ID="txtdescription" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>




            <tr>
                <td class="buttonWrapper alignCenter" colspan="2">

                    <asp:Button ID="btnSave" runat="server" Text="保存"
                        OnClick="btnSave_Click"
                        onmouseout="this.className='inputbutton'"></asp:Button>
                    <asp:Button ID="btnCancle" runat="server" Text="取消"
                        OnClick="btnCancle_Click"></asp:Button>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
