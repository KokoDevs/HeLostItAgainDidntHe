<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatepage.aspx.cs" Inherits="projectron.updatepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <img class="right" style="width:100px; height:100px;" src="images/jjk.jpeg" alt="JJK WEBSITE">
</head>
<body>
    
    <form id="form1" runat="server" action="updatepage.aspx" method="post">
        <a href="HomePage.aspx"> <--back to homepage></a>

        <br />
        <div class="theFormInput">
        <br />
        Username <input type="text" name="unametoup" id="unametoup" value="<%=globaluname %>" placeholder="<%=globaluname %>" class="button" />
        <br />
        Password <input type="text" name="upasstoup" id="upasstoup" value="<%=globalpass %>" placeholder="<%=globalpass %>" class="button" />
        <br />
        Email <input type="text" name="umailtoup" id="umailtoup" value="<%=globalemail %>" placeholder="<%=globalemail %>" class="button" />
        <br />
        <center> <input type="submit" id="updateme" name="updateme" value="To update" class="button" /> </center>
        
        </div>
    </form>
</body>
</html>
