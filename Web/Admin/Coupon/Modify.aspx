<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="CMS.Web.Coupon.Modify" Title="修改页" %>
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
	<td style="width: 8em;">
		标题
	：</td>
	<td>
		<asp:TextBox id="txttitle" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td class="textWrapper">
		优惠券金额
	：</td>
	<td>
		<asp:TextBox id="txtmoney" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td class="textWrapper">
		有效期开始时间
	：</td>
	<td>
		<asp:TextBox ID="txtstartTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		有效期结束时间
	：</td>
	<td class="textWrapper">
		<asp:TextBox ID="txtendTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td class="textWrapper">
		发放时间
	：</td>
	<td>
		<asp:TextBox ID="txtaddTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td class="textWrapper">
		优惠券数量
	：</td>
	<td>
		<asp:TextBox id="txttotal" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		是否删除
	：</td>
	<td>
		<asp:TextBox id="txtisdel" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		状态
	：</td>
	<td>
		<asp:TextBox id="txtstatus" runat="server" ></asp:TextBox>
	</td></tr>
</table>
</div>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

