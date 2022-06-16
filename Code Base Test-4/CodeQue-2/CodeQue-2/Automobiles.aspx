<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Automobiles.aspx.cs" Inherits="CodeQue_2.Automobiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="Pictures/Background-2.JFIF">
    
    <form id="form1" runat="server">
        <div>
        <h1 style="color:gold"><center>Hyper Cars and Bikes</center><br /></h1>
            <br />
        </div>
        <h2 style="color:white;"><center> Select Bike or Hyper Car: <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="180px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem></asp:ListItem>        
        </asp:DropDownList></center></h2>
        <br />   
        
        <center><asp:Image ID="Image1" runat="server" height="300px" Width="550px" /></center>
        <br />
        <br />
        <h2 style="color:white;"><center><asp:Label ID="Label1" runat="server" Text="Price Label"></asp:Label></center></h2>
    </form>
</body>
</html>
