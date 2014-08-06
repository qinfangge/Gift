<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="CMS.Web.Coupon.Show" Title="显示页" %>
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
		title
	：</td>
	<td>
		<asp:Label id="lbltitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		优惠券金额
	：</td>
	<td>
		<asp:Label id="lblmoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		有效期开始时间
	：</td>
	<td>
		<asp:Label id="lblstartTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		有效期结束时间
	：</td>
	<td>
		<asp:Label id="lblendTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		发放时间
	：</td>
	<td>
		<asp:Label id="lbladdTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		优惠券数量
	：</td>
	<td>
		<asp:Label id="lbltotal" runat="server"></asp:Label>
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
		status
	：</td>
	<td>
		<asp:Label id="lblstatus" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




