using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;//for formsauth

namespace LoginSample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (txtUserPass.Value == "123")//use a database method here.
            {
                
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Value, chkPersistCookie.Checked);
                
            }
            else
                Response.Redirect("login.aspx", true);//todo add errormessage to user if wrong
        }
    }
}