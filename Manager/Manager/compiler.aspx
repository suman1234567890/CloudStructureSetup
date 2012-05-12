<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compiler.aspx.cs" Inherits="Manager.compiler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript" src="editarea/edit_area/edit_area_full.js"></script>
    <script language="javascript" type="text/javascript">
        function a(b) {
                editAreaLoader.init({
                id: "textarea1"		// textarea id
	            , syntax: b			// syntax to be uses for highgliting
	            , start_highlight: true		// to display with highlight mode on start-up
                , allow_toggle: false

            });
            c(b);
        }
        function c(b) {
            editAreaLoader.init({
                id: "textarea2"		// textarea id
	            , syntax: b			// syntax to be uses for highgliting
	            , start_highlight: true		// to display with highlight mode on start-up
                , allow_toggle: false

            });
        }
        function func1()
        {
            var ddlReport = document.getElementById('syntax_selection');
            var Text = ddlReport.options[ddlReport.selectedIndex].text;
            alert(Text);
            a(Text);
        }
</script>
    <style type="text/css">
        #textarea1
        {
            width: 898px;
        }
        #textarea2
        {
            width: 898px;
        }
    </style>
</head>
<body bgcolor="#110000" onload="a('c')">
    <form id="form1" runat="server">
        <div style="border-style: none; margin-top:40px; width:100%; height:107px; background-color: #993333;-webkit-border-radius: 10px; font-size: 70px ; color: #FFFFCC;" >
            <strong>&nbsp;Cloud Compiler</strong>
         </div>
            <div style='width:50%;'>
                <div>
                <div style="border-right:solid 1px #003366;background-color:#ECE9D8; text-align:center;height:175px; padding:15px; width: 190px;position:relative; top: 35px; left: 49px;">
                    Select Language:&nbsp
                    
                    <asp:DropDownList AutoPostBack="true" ID="syntax_selection" onChange="func1()" name="D1" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Submit" />
                        <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Result" />
                <asp:Label ID="Label1" runat="server" BackColor="#CC0066" Text="Label"></asp:Label>
                    </div>



                    &nbsp;</div>
                <div style="padding:15px; position:relative; top: -203px; left: 310px; width: 825px;">
                    <textarea id="textarea1" runat="server" name="content" rows="15" cols="30" style='position:relative'>
                    
                    </textarea>
                    <br />
                    <br />
                     <textarea id="textarea2" runat="server" name="content" rows="15" cols="30"
                        style='position:relative; top: 0px; left: 0px; width: 899px;'>
                    
                    </textarea>



                </div>
            </div>
    </form>
</body>
</html>
