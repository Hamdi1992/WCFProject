using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormHostingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                string creditnumber = CreditNumberbox.Text;
                string templateName = templatenameBox.Text;
                BackEndConectedService_.BackEServiceClient cl = new BackEndConectedService_.BackEServiceClient();
                string res = cl.GenerateTemplateAsync(int.Parse(creditnumber), templateName).Result;
                resBox.Text = res;
                cl.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                resBox.Text = ex.Message;
            }
        }
    }
}
