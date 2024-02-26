<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="projectron.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <img class="right" style="width:100px; height:100px;" src="images/jjk.jpeg" alt="JJK WEBSITE">
</head>
<body>
    <form id="form1" runat="server">
        <div class="theFormInput">
            Hello, <%=msg%>
            <center> <input type="text" id="uname" name="uname" placeholder="UserName" class="button" /> </center>
            <center> <input type="password" id="upass" name="upass" placeholder="Password" class="button" /> </center>
            <center> <input type="submit" id="usub" name="usub" value="Submit" class="button"/> </center>
            <br />
            <br />

            <center>You don`t have an account? <a href="SubmitPage.aspx"> Register</a>
                <br />
                <br />
                <a href="HomePage.aspx"> Back to homepage</a>
            </center>

            
        </div>
    </form>
</body>
</html>
