using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using sunset;

public partial class SunSet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SunSetRiseService ssrs = new SunSetRiseService();
        SunSet s = new SunSet();
        LatLonDate ll=null;
        
        ll.Latitude = 0;
        ll.Longitude = 0;
        ll.Month = 12;
        ll.Year = 2013;
        ll.Day = 17;
        ll.TimeZone = 0;
     Label1.Text=( ssrs.GetSunSetRiseTime(ll)).ToString();
    }
}