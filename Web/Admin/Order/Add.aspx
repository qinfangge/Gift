<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="CMS.Web.Order.Add" Title="增加页" %>

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
		<asp:TextBox id="txtid" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		orderId
	：</td>
	<td>
		<asp:TextBox id="txtorderId" runat="server" ></asp:TextBox>
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
		userId
	：</td>
	<td>
		<asp:TextBox id="txtuserId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		订单是否被删除
	：</td>
	<td>
		<asp:TextBox id="txtisDel" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		配送方式 如韵达 申通
	：</td>
	<td>
		<asp:TextBox id="txtwuliuId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		付款方式 如 淘宝、网银
	：</td>
	<td>
		<asp:TextBox id="txtpayId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		是否已经付款
	：</td>
	<td>
		<asp:TextBox id="txtisPay" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		收货地址
	：</td>
	<td>
		<asp:TextBox id="txtaddressId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		couponId
	：</td>
	<td>
		<asp:TextBox id="txtcouponId" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		memo
	：</td>
	<td>
		<asp:TextBox id="txtmemo" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		trackingNumber
	：</td>
	<td>
		<asp:TextBox id="txttrackingNumber" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		state
	：</td>
	<td>
		<asp:TextBox id="txtstate" runat="server" ></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
