using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShipperClient.NwService;

namespace ShipperClient
{
    public partial class Shippers : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGetShipper_Click(object sender, EventArgs e)
        {
            var host = new ShipperServiceClient();
            TextBoxShowShipperID.Text = host.GetShipperByID(int.Parse(TextBoxInsertShipperID.Text)).ShipperID.ToString();
            TextBoxShowCompanyName.Text = host.GetShipperByID(int.Parse(TextBoxInsertShipperID.Text)).CompanyName;
            TextBoxShowPhone.Text = host.GetShipperByID(int.Parse(TextBoxInsertShipperID.Text)).Phone;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            var host = new ShipperServiceClient();
            host.SaveShipper(int.Parse(TextBoxShowShipperID.Text), TextBoxShowCompanyName.Text, TextBoxShowPhone.Text);
        }
    }
}