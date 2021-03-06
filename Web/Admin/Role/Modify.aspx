﻿<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="CMS.Web.Admin.Role.Modify" Title="修改角色" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MinNav" runat="server">
    修改角色
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formView">
        <table cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr style="display: none">
                <td>id：</td>
                <td>
                    <asp:Label ID="lblid" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
            <td style="width: 8em;">用户名：</td>
            <td class="textWrapper">
                <asp:TextBox ID="RoleName" runat="server" ></asp:TextBox>
            </td>
            </tr>
             <tr>
                <td>是否显示：</td>
                <td class="checkBoxWrapper">
                    <asp:CheckBox ID="IsShow" runat="server"></asp:CheckBox>
                </td>
            </tr>
             <tr>
                <td >是否默认：</td>
                <td class="checkBoxWrapper">
                    <asp:CheckBox ID="IsDefault" runat="server"></asp:CheckBox>
                     
                </td>
            </tr>

            <tr>
                <td>排序：</td>
                <td class="date">
                  <asp:TextBox ID="Sort" runat="server" ></asp:TextBox> <span class="tip">此项是整数</span> 
                </td>
            </tr>

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

