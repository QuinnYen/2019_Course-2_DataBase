<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="character.aspx.cs" Inherits="db_R6_product.character" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        body {background-color: darkslategray;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <h1 style="color: white">角色頁面</h1>
            <asp:Button ID="Button1" runat="server" Text="返回" Height="50px" Width="100px" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:Image ID="Image1" runat="server" Height="250px" Width="150px" ImageAlign="Left"/>
            <asp:Table ID="Table1" runat="server" Width="800px" Font-Size="X-Large" CellSpacing="5" CellPadding="0" Height="250px" >
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell>▲</asp:TableCell>
                <asp:TableCell style="color: white">角色名稱：</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Labe_01" runat="server" style="color: #FFFF00"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>▲</asp:TableCell>
                <asp:TableCell style="color: white">角色國籍：</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Labe_02" runat="server" style="color: #FFFF00"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell>▲</asp:TableCell>
                <asp:TableCell style="color: white">攻方守方：</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Labe_03" runat="server" style="color: #FFFF00"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>▲</asp:TableCell>
                <asp:TableCell style="color: white">角色裝甲：</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Labe_04" runat="server" style="color: #FFFF00"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
                 <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell>▲</asp:TableCell>
                <asp:TableCell style="color: white">角色單位：</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Labe_05" runat="server" style="color: #FFFF00"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>▲</asp:TableCell>
                <asp:TableCell style="color: white">角色速度：</asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Labe_06" runat="server" style="color: #FFFF00"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
            <hr style="height: 20px" />
        </div>
        <div>
            <h2 style="color: white">▼遊玩風格</h2>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Labe_07" runat="server" style="color: #FFFF00"></asp:Label>
            </asp:Panel>
        </div>
         <div>
            <h2 style="color: white">▼人物背景</h2>
            <asp:Panel ID="Panel2" runat="server">
                 <asp:Label ID="Labe_08" runat="server" style="color: #FFFF00"></asp:Label>
            </asp:Panel>
        </div>
    </form>
    
</body>
</html>
