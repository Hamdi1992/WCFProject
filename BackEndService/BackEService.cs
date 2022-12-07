using BackEndService.ServiceCustomers;
using BackEndService.TemplateService;
using System;
using System.Diagnostics;

namespace BackEndService_
{
    public class BackEService : IBackEService
    {
        public string GenerateTemplate(int creditNumber, string templateName)
        {
            try
            {
                CusServClient client = new CusServClient();
                CustomerDC Cdc = client.getCustomer(creditNumber);
                TemplateServiceClient client_ = new TemplateServiceClient();
                TemplateDC Tdc = client_.getTemplate(templateName);
                // name - creditnumber - summe - date => the order to generate the template
                string temp = string.Format(Tdc.TextSample, Cdc.Name, Cdc.Creditnumber, Cdc.amount, Cdc.dueDate);
                client.editCustomer(creditNumber, temp);
                return temp;
            }
            catch (Exception exc )
            {
                Debug.WriteLine(exc.ToString());
                return null;
            }
        }

        public void GenerateSeedData()
        {
            CusServClient client = new CusServClient();
            TemplateServiceClient client_ = new TemplateServiceClient();
            client.GenerateSeedData();
            client_.GenerateSeedData();
        }
    }
}
