using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using manish;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GlobalWeather gw = new GlobalWeather();
        Label1.Text = gw.GetWeather("lucknow", "india");
        DropDownList1.DataSource = gw.GetCitiesByCountry("india");
        DropDownList1.DataBind();
        GridView1.DataSource = gw.GetCitiesByCountry("pakistan");
        GridView1.DataBind();
    }
}