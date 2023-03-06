<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginSample.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
        <div class="topnav" id="myTopnav">
                <a href="Default.aspx" >Home</a>
                <a href="Restricted.aspx">Restricted</a>
                <a href="Login.aspx" class="active">LoginPage</a>
                
                <a href="javascript:void(0);" class="icon" onclick="myFunction()">
                <i class="fa fa-bars"></i>
                </a>
            </div>
        <h3>
    <font face="Verdana">Logon Page</font>
        </h3>
        <table>
            <tr>
                <td>Email:</td>
                <td><input id="txtUserName" type="text" runat="server"></td>
                <td><ASP:RequiredFieldValidator ControlToValidate="txtUserName"
                    Display="Static" ErrorMessage="*" runat="server" 
                    ID="vUserName" /></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><input id="txtUserPass" type="password" runat="server"></td>
                <td><ASP:RequiredFieldValidator ControlToValidate="txtUserPass"
                Display="Static" ErrorMessage="*" runat="server"
                ID="vUserPass" />
                </td>
            </tr>
            <tr>
                <td>Persistent Cookie:</td>
                <td><ASP:CheckBox id="chkPersistCookie" runat="server" autopostback="false" /></td>
                <td></td>
            </tr>
        </table>
                <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" /><p></p>
        <asp:Label id="lblMsg" ForeColor="red" Font-Name="Verdana" Font-Size="10" runat="server" />
    </form>
</body>
</html>
