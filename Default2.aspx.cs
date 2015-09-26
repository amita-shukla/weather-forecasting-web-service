using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using curency;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CurrencyConvertor cc = new CurrencyConvertor();
            Label1.Text = cc.ConversionRate(Currency.USD, Currency.INR).ToString();

            DropDownList1.DataSource = Enum.GetValues(typeof(curency.Currency));
            DropDownList1.DataBind();
            DropDownList2.DataSource = Enum.GetValues(typeof(curency.Currency));
            DropDownList2.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         curency.CurrencyConvertor conver = new curency.CurrencyConvertor();
         curency.Currency From = (curency.Currency)Enum.Parse(typeof(curency.Currency),DropDownList1.SelectedValue.ToString(), true);
          curency.Currency To = (curency.Currency)Enum.Parse(typeof(curency.Currency),DropDownList2.SelectedValue.ToString(), true);
            double d = conver.ConversionRate(From, To);
        /* web service  * method to call for conversion currency rate */
         Label2.Text="Convert Currency : "+(d * Convert.ToDouble(TextBox1.Text)).ToString();
         Label2.Visible = true;
    }
}