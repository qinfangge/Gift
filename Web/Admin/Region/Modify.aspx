<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="CMS.Web.Region.Modify" Title="修改页" %>
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
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td>
		name
	：</td>
	<td>
		<asp:TextBox id="txtname" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		pid
	：</td>
	<td>
		<asp:TextBox id="txtpid" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		sort
	：</td>
	<td>
		<asp:TextBox id="txtsort" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		level
	：</td>
	<td>
		<asp:TextBox id="txtlevel" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		longcode
	：</td>
	<td>
		<asp:TextBox id="txtlongcode" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td>
		code
	：</td>
	<td>
		<asp:TextBox id="txtcode" runat="server" ></asp:TextBox>
	</td></tr>
</table>

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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

