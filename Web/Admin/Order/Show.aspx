<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="CMS.Web.Order.Show" Title="显示页" %>
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
		orderId
	：</td>
	<td>
		<asp:Label id="lblorderId" runat="server"></asp:Label>
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
		userId
	：</td>
	<td>
		<asp:Label id="lbluserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		订单是否被删除
	：</td>
	<td>
		<asp:Label id="lblisDel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		配送方式 如韵达 申通
	：</td>
	<td>
		<asp:Label id="lblwuliuId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		付款方式 如 淘宝、网银
	：</td>
	<td>
		<asp:Label id="lblpayId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		是否已经付款
	：</td>
	<td>
		<asp:Label id="lblisPay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		收货地址
	：</td>
	<td>
		<asp:Label id="lbladdressId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		couponId
	：</td>
	<td>
		<asp:Label id="lblcouponId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		memo
	：</td>
	<td>
		<asp:Label id="lblmemo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		trackingNumber
	：</td>
	<td>
		<asp:Label id="lbltrackingNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td>
		state
	：</td>
	<td>
		<asp:Label id="lblstate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




