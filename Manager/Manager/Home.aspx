<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeBehind="Home.aspx.cs" Inherits="Manager.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1
        {
            width: 707px;
            height: 280px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td>
        <asp:Label ID="Label2" runat="server" Text="Number (1) :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="417px" Height="162px" 
                        TextMode="MultiLine"></asp:TextBox>
                    
                </td>
                
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Category"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="Sum">Sum</asp:ListItem>
                        <asp:ListItem>Sub</asp:ListItem>
                        <asp:ListItem>Multi</asp:ListItem>
                        <asp:ListItem>Div</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
                </td>
                
            </tr>
            
        </table>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="View Result" />
        </p>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
