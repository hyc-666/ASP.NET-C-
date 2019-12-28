<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="例题3_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="left" border ="1"  style="background-color:Gary">
            <tr><td class="style1">
                <strong>商品图片</strong></td>
                </tr>
            <tr><td class ="style4">
    
        <asp:ImageButton ID="ImageButton1" runat="server"
            ImageUrl="~/InkedQQ图片.jpg"  OnClientClick="ImageButton1_Click"
             Height="79px"  />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
