using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBLayer dBLayer = new DBLayer();
            LabelArlyTextFromDB.Text = dBLayer.GetArlyText();

            //todo
            //GetArlyHeader as above
            //GetTrineText as above
            //

        }
    }
}