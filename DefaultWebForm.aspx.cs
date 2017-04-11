using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyService;

public partial class DefaultWebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void CheckCall_Click(object sender, EventArgs e)
    {
        MyServiceClass service = new MyServiceClass();
        service.userCredentials = new userCredentials()
        {
            userName = TextBoxuserName.Text,
            password = TextBoxpassword.Text
        };
    }
}