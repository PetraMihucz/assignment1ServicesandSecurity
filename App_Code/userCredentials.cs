using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for userCredentials
/// </summary>
public class userCredentials : System.Web.Services.Protocols.SoapHeader
{
    public string userName { get; set; }
    public string password { get; set; }


    public bool IsValid()
    {
        //Write the logic to Check the User Details From DataBase  
        //i can chek with some hardcode details UserName=Nitin and Password=Pandit  
        return this.userName == "Nitin" && this.password == "Pandit";
        //it'll check the details and will return true or false   
    }
}