<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitPage.aspx.cs" Inherits="projectron.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="signup.css" rel="stylesheet" />
    <img class="right" style="width:100px; height:100px;" src="images/jjk.jpeg" alt="JJK WEBSITE">
    <script type="text/javascript">

        function CheckUname()
        {
            var usern;
            usern = document.getElementById("uname").value;           
            if (usern == "") {
                alert("user name is empty.");
                return false;
            }
            if (usern.length < 4 || usern.length > 10) {
                alert("username is NOT between 4-10 letters");
                return false;
            }
            return true;
        }

        function CheckUpass()
        {
            var passw;
            passw = document.getElementById("upass").value;
            if (passw == "")
            {
                alert("password is empty.");
                return false;
            }
            if (passw.length < 3)
            {
                alert("password is too short.");
                return false;
            }
           
            return true;
        }

        function CheckUmail()
        {
            email = document.getElementById("email").value;
            if (email == "")
            {
                alert("email is empty.");
                return false;
            }
            return true;
        }

        function CheckGender()
        {
            var male = document.getElementById('ugender1').checked;
            var female = document.getElementById('ugender2').checked;
            var rnts = document.getElementById('ugender3').checked;
            if (male == false && female == false && rnts == false)
            {
                alert("gender is empty.");
                return false;
            }
            return true;
            
        }
        
        function CheckAll()
        {
            
            var check1 = CheckUname();
            var check2 = CheckUpass();
            var check3 = CheckUmail();
            var check4 = CheckGender();
            
            if (check1 == true && check2==true && check3 == true && check4 == true) 
                return true;
            return false;
                
        }



    </script>
    <title>Sign Up</title> 

    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server" action="SubmitPage.aspx" method="post" onsubmit="return CheckAll()">
        <div class="theFormInput">
            <h1>
                    <center>Please Register </center>   
            </h1>
        <center> <input type="text" id="uname" name="uname" placeholder="UserName" class="button"/> </center> 
        <br />
                
       <center> <input type="password" id="upass" name="upass" placeholder="Password" class="button"/> </center>
        <br />
        
       <center> <input type="email" id="email" name="email" placeholder="Email" class="button"/> </center>
       
        <br />
        
        <center> Male: <input type="radio" id="ugender1" name="ugender" value ="male" />
        Female: <input type="radio" id="ugender2" name="ugender" value ="female" /> 
        Rather not to say: <input type="radio" id="ugender3" name="ugender" value ="rnts" /> 
        <br />
        <br />
        
        <center> <input type="submit" id="usub" name="usub" value="Submit" class="button"/> </center>
            <br />
            <br />
            <center>Already have an account? <a href="LoginForm.aspx"> Log in</a>
                <br />
                <br />
                <a href="HomePage.aspx"> Back to homepage</a>
            </center>
        </div>
    </form>
</body>
</html>
