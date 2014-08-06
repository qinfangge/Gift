<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="CMS.Web.Comment.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <div class="formView">
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td>
		id
	：</td>
	<td>
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td>
		content
	：</td>
	<td>
		<asp:TextBox id="txtcontent" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		reply
	：</td>
	<td>
		<asp:TextBox id="txtreply" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		addTime
	：</td>
	<td>
		<asp:TextBox ID="txtaddTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		objectId
	：</td>
	<td>
		<asp:TextBox id="txtobjectId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		userId
	：</td>
	<td>
		<asp:TextBox id="txtuserId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		isdel
	：</td>
	<td>
		<asp:TextBox id="txtisdel" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		评论的类型 1、产品 2、新闻
	：</td>
	<td>
		<asp:TextBox id="txttype" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		isChecked
	：</td>
	<td>
		<asp:TextBox id="txtisChecked" runat="server" ></asp:TextBox>
	</td></tr>
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

