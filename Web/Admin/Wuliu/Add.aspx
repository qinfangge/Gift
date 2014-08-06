<%@ Page Language="C#" MasterPageFile="../Master/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="CMS.Web.Wuliu.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/base/form.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formView">
        <table cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td style="width: 8em;">快递名称：
	：</td>
                <td class="textWrapper">
                    <asp:TextBox ID="txtname" runat="server"> </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="textWrapper">快递费用：
	：</td>
                <td>
                    <asp:TextBox ID="txtmoney" runat="server"> </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>备注：
	：</td>
                <td>
                    <asp:TextBox ID="txtmemo" runat="server" TextMode="MultiLine"> </asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
