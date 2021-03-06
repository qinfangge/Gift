﻿<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="CMS.Web.Admin.Node.Add" Title="添加权限" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MinNav" runat="server">
    添加权限 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <div class="formView">
        <table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td style="width: 8em;">
		权限名称
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="Name" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td >
		地址
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="URL" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td >
		组
	：</td>
	<td class="textWrapper">
        <asp:DropDownList ID="Group" runat="server">

        </asp:DropDownList>
		
	</td></tr>
	
	
	<tr>
	<td >
		排序
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="Sort" runat="server" ></asp:TextBox>
	</td></tr>
	<tr>
	<td >
		是否是菜单
	：</td>
	<td class="checkBoxWrapper">
		<asp:CheckBox ID="IsMenu"  runat="server" Checked="True" />
	</td></tr>

            <tr>
	<td >
		菜单名称
	：</td>
	<td class="textWrapper">
		<asp:TextBox id="MenuName" runat="server" ></asp:TextBox>
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
    
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
