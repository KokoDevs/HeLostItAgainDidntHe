<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="projectron.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <link rel="icon" type="image/x-icon" href="/images/jjk.jpeg">
</head>
    
<body >    
    <div class="theHomeInput">
    

    <center>Hello, <strong><%=usersta %>!</strong></center>
        

    </div>
<br />
        <a href ="aboutMe.aspx" class="button"> About this website </a> 
        <%=adminPanel %>
        <%=disconect %>
        <%=register %>
        <%=login %>
        <%=update %>
        <br />
    
    <br />
    <img class="center" style="width:250px; height:250px; text-align:center;" src="images/jjk.jpeg" alt="JJK WEBSITE">
    <p>
        <center><small>This website was made by Ron Yakar :)</small></center>
    </p>

</body>
</html>
