<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="db_R6_product.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 274px;
            margin-top: 0px;
        }
        body {background-color: darkslategray;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        
        
        <div>
            <asp:Image ID="logo" runat="server" Height="250px" Width="220px" ImageAlign="Left"/>
            <h1 style="color: #FFFF00">109-2_資料庫系統_期末專題實作</h1>
            <h3 style="color: #FFFF00">專題組長：[ B10602034 - 顏　寬 ] - 程式開發與資料庫設計</h3>
            <h3 style="color: #FFFF00">專題組員：[ B10602050 - 黃育群 ] - 資源擷取與資料整合</h3>
            <h3 style="color: #FFFF00">專題組員：[ B10602026 - 徐浩芛 ] - 錯誤檢查與介面設計</h3>
            <h3 style="color: #FFFF00">Rainbow Six 幹員介紹</h3>
        </div>
        <br /><br /><br />
        <div>
            <asp:Button ID="Att" runat="server" Height="70px" Text="攻擊方" Width="270px" BackColor="Gray" BorderStyle="Ridge" ForeColor="White" OnClick="Att_Click" />
            <asp:Button ID="Def" runat="server" Height="70px" Text="防守方" Width="270px" BackColor="Gray" BorderStyle="Ridge" ForeColor="White" OnClick="Def_Click" />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="60px" Width="325px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="1">---</asp:ListItem>
                <asp:ListItem Selected="False" Value="2">軟突破</asp:ListItem>
                <asp:ListItem Selected="False" Value="3">硬突破</asp:ListItem>
                <asp:ListItem Selected="False" Value="4">反硬突破</asp:ListItem>
                <asp:ListItem Selected="False" Value="5">前鋒</asp:ListItem>
                <asp:ListItem Selected="False" Value="6">後衛</asp:ListItem>
                <asp:ListItem Selected="False" Value="7">側翼</asp:ListItem>
                <asp:ListItem Selected="False" Value="8">游擊</asp:ListItem>
                <asp:ListItem Selected="False" Value="9">反游擊</asp:ListItem>
                <asp:ListItem Selected="False" Value="10">護盾</asp:ListItem>
                <asp:ListItem Selected="False" Value="11">牽制</asp:ListItem>
                <asp:ListItem Selected="False" Value="12">陷阱</asp:ListItem>
                <asp:ListItem Selected="False" Value="13">情資蒐集者</asp:ListItem>
                <asp:ListItem Selected="False" Value="14">情資阻絕者</asp:ListItem>
                <asp:ListItem Selected="False" Value="15">區域阻絕者</asp:ListItem>
                <asp:ListItem Selected="False" Value="16">固守者</asp:ListItem>
                <asp:ListItem Selected="False" Value="17">確保安全</asp:ListItem>
                <asp:ListItem Selected="False" Value="18">群體控制</asp:ListItem>
                <asp:ListItem Selected="False" Value="19">掩體火力</asp:ListItem>
                <asp:ListItem Selected="False" Value="20">增益效果</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Btn_clear" runat="server" Height="45px" OnClick="Btn_clear_Click" Text="清除條件" Width="106px" />
        </div>
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton4" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton5" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton6" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton7" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton8" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton9" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton10" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton11" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton12" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton13" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton14" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton15" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton16" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton17" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton18" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton19" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton20" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton21" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton22" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton23" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton24" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton25" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton26" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton27" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton28" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton29" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton30" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton31" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton32" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton33" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton34" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton35" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton36" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton37" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton38" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton39" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton40" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton41" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton42" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton43" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton44" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton45" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton46" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton47" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton48" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton49" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton50" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton51" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton52" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton53" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton54" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton55" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton56" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton57" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton58" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
            <asp:ImageButton ID="ImageButton59" runat="server" Height="250px" Width="150px" OnClick="bt_click" />
        </div>
    </form>
</body>
</html>
