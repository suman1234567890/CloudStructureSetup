


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sourcecode.aspx.cs" Inherits="Manager.sourcecode" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Source Code Submission

</title>
    

    <style type="text/css">
    
 body{
 margin:20px 0px;
 padding:0px;
 text-align:center;


background-color:#0A0F18 ;

}



#content{


margin-top:100px;
width:1000px;
height:600px;
padding:20px;

border:1px solid #003366;
margin-left:auto;
margin-right:auto;
text-align:left;

}


    </style>


<script language="javascript" type="text/javascript" src="editarea/edit_area/edit_area_full.js"></script>
<script language="javascript" type="text/javascript">
function a (b){
editAreaLoader.init({
	id : "textarea1"		// textarea id
	,syntax: b			// syntax to be uses for highgliting
	,start_highlight: true		// to display with highlight mode on start-up
,allow_toggle:false

});
}
</script>


</head>

<body onload="a('c')">

<img src="headerforCloudJob.png" alt="imagenotfound"/>
<div id="content">
 <table  style='height:100%; width:100%' >
 <tr>
 <td style='width:20%' >
<div style="border-right:solid 1px #003366;background-color:#ECE9D8; text-align:center;height:200px; padding:15px;">
Select Language:&nbsp



<select id="syntax_selection" onchange="a(this.value)" >
    <option value="c">C</option>
    <option value="java">java</option>
    <option value="cpp">C++</option>
</select>


</div></td> <td width="80%" >

<div style="padding:15px;">
<textarea id="textarea1" name="content" cols="100" rows="15">
/*This is some c code that will be editable with EditArea.*/
int cc( char *p , int a);
</textarea>

</div></td></tr>



    </table>
    </div>
    </body>
</html>












