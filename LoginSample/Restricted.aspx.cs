using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginSample
{
    public partial class Restricted : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBLayer layer = new DBLayer();
            if(!Page.IsPostBack)
                TextBoxToDB.Text=layer.GetArlyText();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            //lagre text til db
            DBLayer layer = new DBLayer();
            layer.UpdateArlyText(TextBoxToDB.Text);
        }
    }
}