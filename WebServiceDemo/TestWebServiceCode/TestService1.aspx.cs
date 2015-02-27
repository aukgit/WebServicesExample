using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDemo.TestWebServiceCode {
    public partial class TestService1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            ServiceReference1.ServiceSample1SoapClient client = new ServiceReference1.ServiceSample1SoapClient();
            var input = this.TextBox1.Text;

            var output = client.HelloWorld(input);
            this.Label1.Text = output;
        }
    }
}