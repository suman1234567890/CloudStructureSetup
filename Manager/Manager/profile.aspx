<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Manager.profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 143px;
            text-align: left;
        }
        .style2
        {
            color: #FFFFFF;
        }
        .style3
        {
            width: 143px;
            text-align: left;
            color: #FFFFFF;
        }
        #Text1
        {
            width: 184px;
        }
        #Text2
        {
            width: 183px;
        }
        .style4
        {
            width: 126px;
            color: #FFFFFF;
            font-weight: bold;
        }
        .style5
        {
            color: #FFFFCC;
        }
    </style>
</head>
<body bgcolor="#0f0700">
<form id="form1" runat="server">
    <div style='border-style: none; margin-top:40px; width:100%; height:107px; background-color: #993333;-webkit-border-radius: 10px; font-size: 70px; font-family: &#039;' 
        class="style5"><strong>&nbsp;Cloud Compiler</strong></div>
    
    <div style="height: 438px">
    
        <div style="border-style: ridge; border-width: thick; margin: 5%; width: 36%; height: 223px; position:absolute; top: 255px; left: 53px; -webkit-border-radius: 10px;">
        
            <table style="margin-top:20px;margin-left:20px;width:107%; height: 130px;">
                <tr>
                    <td class="style1">
                        &nbsp;<span class="style2"><strong>Username</strong></span></td>
                    <td>
                        <asp:TextBox ID="TextBox4" BorderStyle="Ridge" runat="server" Width="194px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="style3">
                        <strong>&nbsp;Password</strong></td>
                    <td>
                        <asp:TextBox ID="TextBox5" BorderStyle="Ridge" runat="server" Width="194px" 
                            TextMode="Password"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="style3">
                        <strong>&nbsp;</strong></td>
                    <td>
                        <asp:Button ID="Button1" runat="server"  style="text-align: right" 
                            Text="Sign In" onclick="Button1_Click" />
                    </td>
                    
                </tr>
                
            </table>
        </div>
        <div style="border-style: ridge; border-width:thick;margin: 10%; width: 38%; height: 223px; position:absolute; top: 217px; left: 555px; -webkit-border-radius: 10px;">
            <table style="width:100%; height: 166px; margin-top:30px;margin-left:30px">
                <tr>
                    <td class="style4">
                        Full Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Ridge" Width="267px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="style4">
                        Username</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Ridge" Width="268px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="style4">
                        Password</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Ridge" Width="268px" 
                            TextMode="Password"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        
                        <asp:Button ID="Button2" runat="server" Text="Sign Up" 
                            onclick="Button2_Click" />
                        
                    </td>
                    
                </tr>
                
            </table>
            a<asp:Label ID="Label1" runat="server" ForeColor="#FFFFCC" 
                Text="Label"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
