<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="CMS.Web.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        * {
            margin: 0;
            padding: 0;
        }
        .close {
            position:absolute;
            top:5px;
            right:5px;
        }
        td {
            vertical-align:middle;
            text-align:center;
            height:200px;
            width:200px;
            border:1px solid #ccc;
            position:relative;
        }
        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <img src="http://www.zlcool.com/d/file/2011/03/17/3863ecb16028554682c6dd4617e28248.gif"/>
            </div>
        </div>

        <table>
            <tr><td>
                <a class="close" href="#">X</a>
                <img src="http://www.zlcool.com/d/file/2011/03/17/3863ecb16028554682c6dd4617e28248.gif"/></td></tr>
        </table>
    </form>
</body>
</html>
