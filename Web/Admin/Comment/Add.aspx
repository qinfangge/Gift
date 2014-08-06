<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="CMS.Web.Comment.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
    <script type="text/javascript" src="/Js/libs/My97DatePicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formView">
        <table cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td style="width: 8em;">评论
	：</td>
                <td>
                    <asp:TextBox ID="txtcontent" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>回复
	：</td>
                <td>
                    <asp:TextBox ID="txtreply" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="textWrapper">添加时间
	：</td>
                <td>
                    <asp:TextBox ID="txtaddTime" CssClass="date" runat="server" onclick="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>产品ID
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="txtobjectId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>用户ID
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="txtuserId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>是否删除
	：</td>
                <td class="checkBoxWrapper">
                    <asp:CheckBox ID="txtisdel" runat="server" OnCheckedChanged="txtisdel_CheckedChanged"></asp:CheckBox>
                </td>
            </tr>
            <tr>
                <td>评论的类型 1、产品 2、新闻
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="txttype" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>审核
	：</td>
                <td class="checkBoxWrapper">
                    <asp:CheckBox ID="txtisChecked" runat="server"></asp:CheckBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
