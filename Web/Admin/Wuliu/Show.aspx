<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="CMS.Web.Wuliu.Show" Title="显示页" %>
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
		name
	：</td>
	<td>
		<asp:Label id="lblname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		money
	：</td>
	<td>
		<asp:Label id="lblmoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		memo
	：</td>
	<td>
		<asp:Label id="lblmemo" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




