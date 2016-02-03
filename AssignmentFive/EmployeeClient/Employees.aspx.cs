using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using EmployeeClient.EmployeeReference;

namespace EmployeeClient
{
    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFind_Click(object sender, EventArgs e)
        {
            try
            {
                var host = new EmployeeServiceClient();
                TextBoxShowEmployeeID.Text = host.GetEmployeeByID(int.Parse(TextBoxFindEmployee.Text)).EmployeeID.ToString();
                TextBoxShowFirstname.Text = host.GetEmployeeByID(int.Parse(TextBoxFindEmployee.Text)).FirstName;
                TextBoxShowLastname.Text = host.GetEmployeeByID(int.Parse(TextBoxFindEmployee.Text)).LastName;
                TextBoxShowTitle.Text = host.GetEmployeeByID(int.Parse(TextBoxFindEmployee.Text)).Title;
                TextBoxShowAddress.Text = host.GetEmployeeByID(int.Parse(TextBoxFindEmployee.Text)).Address;
                TextBoxShowCity.Text = host.GetEmployeeByID(int.Parse(TextBoxFindEmployee.Text)).City;
            }
            catch (FaultException error)
            {
                MessageBox.Show($"Something went wrong here, please read the message for more details: {error.Message}");
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var host = new EmployeeServiceClient();
                host.SaveEmployee(int.Parse(TextBoxShowEmployeeID.Text), TextBoxShowFirstname.Text, TextBoxShowLastname.Text, TextBoxShowTitle.Text, TextBoxShowAddress.Text, TextBoxShowCity.Text);
            }
            catch (FaultException error)
            {
                MessageBox.Show($"Something went wrong here, please read the message for more details: {error.Message}");
            }
        }
    }
}
