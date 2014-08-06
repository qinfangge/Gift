<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="CMS.Web.Coupon.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <div class="formView"> 
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td style="width: 8em;">
		标题
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="txttitle" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td class="textWrapper">
		优惠券金额
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="txtmoney" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		有效期开始时间
	：</td>
	<td class="textWrapper">
		<asp:TextBox ID="txtstartTime"  onclick="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})" CssClass="date" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		有效期结束时间
	：</td>
	<td class="textWrapper">
		<asp:TextBox ID="txtendTime"  onclick="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})" CssClass="date" runat="server"  ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		发放时间
	：</td>
	<td class="textWrapper">
		<asp:TextBox ID="txtaddTime"  onclick="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})" CssClass="date" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		优惠券数量
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="txttotal" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		isdel
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="txtisdel" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		status
	：</td>
	<td>
		<asp:TextBox id="txtstatus" runat="server" ></asp:TextBox>
	</td></tr>
</table>
</div>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
