<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="CMS.Web.Comment.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td>
		id
	：</td>
	<td>
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		content
	：</td>
	<td>
		<asp:Label id="lblcontent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		reply
	：</td>
	<td>
		<asp:Label id="lblreply" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		addTime
	：</td>
	<td>
		<asp:Label id="lbladdTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		objectId
	：</td>
	<td>
		<asp:Label id="lblobjectId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		userId
	：</td>
	<td>
		<asp:Label id="lbluserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		isdel
	：</td>
	<td>
		<asp:Label id="lblisdel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		评论的类型 1、产品 2、新闻
	：</td>
	<td>
		<asp:Label id="lbltype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		isChecked
	：</td>
	<td>
		<asp:Label id="lblisChecked" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




