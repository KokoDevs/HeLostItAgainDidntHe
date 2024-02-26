<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="projectron.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body >
    
    <form id="form1" runat="server">
        <div class="theFormInput">
            <a href="HomePage.aspx"> <-- Back to home page</a>
            <center>
                <%=WebUsersTable %>
                <input type="text" id="delusr" name="delusr" />
                <br />
                <input type="submit" id="delme" name="delme" value="DELETE USER" />
            </center>
        </div>
    </form>
</body>

</html>
