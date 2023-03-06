<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restricted.aspx.cs" Inherits="LoginSample.Restricted" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restricted</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Load an icon library to show a hamburger menu (bars) on small screens -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="Styles.css" rel="stylesheet" />

    <script>
        function myFunction() {
          var x = document.getElementById("myTopnav");
          if (x.className === "topnav") {
            x.className += " responsive";
          } else {
            x.className = "topnav";
          }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="topnav" id="myTopnav">
                <a href="Default.aspx">Home</a>
                <a href="Restricted.aspx" class="active">Restricted</a>
                <a href="Login.aspx">LoginPage</a>
                
                <a href="javascript:void(0);" class="icon" onclick="myFunction()">
                <i class="fa fa-bars"></i>
                </a>
            </div>
            <p>This is a restricted zone. Logged in users only!</p>
            <p>Skrive inn text, lagre til db her</p>
            <asp:TextBox ID="TextBoxToDB" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonSave" runat="server" Text="Lagre" OnClick="ButtonSave_Click" />




        </div>
    </form>
</body>
</html>
