<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="CMS.Web.Attribute.Modify" Title="修改页" %>
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
	<td style="width: 8em;">
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td>
		名称
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="txtname" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		样式
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="txtstyle" runat="server" ></asp:TextBox>
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

