using System;
using ServiceCustomers.DataContracts;
using ServiceCustomers.dbContexts;
using ServiceCustomers_;
using static Mono.Security.X509.X520;

namespace ServiceCustomers_
{
    public class CusServ : ICusServ
    {
        public CustomerDC GetDataUsingDataContract(CustomerDC customer)
        {
            throw new NotImplementedException();
        }
        public CustomerDC addCustomer(string Name, DateTime dueDate, Int64 amount, Int32 Creditnumber, Int32 phonenbr, string template)
        {
            try {
                CustomerDBContext Customermanager = new CustomerDBContext();
                return Customermanager.addCustomer(Name, dueDate, amount, Creditnumber, phonenbr,template);
            } 
            catch ( Exception excp)
            {
                Console.WriteLine(excp.Message);
                return null;
            }
            
        }

        public Boolean removeCustomer(Int32 Creditnumber)
        {
            
            try
            {
                CustomerDBContext Customermanager = new CustomerDBContext();
                Customermanager.removeCustomer(Creditnumber);
                return Customermanager.removeCustomer(Creditnumber);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return false;
            }
        }

        public CustomerDC getCustomer(Int32 Creditnumber)
        {
            try
            {
                CustomerDBContext Customermanager = new CustomerDBContext();
                return Customermanager.getCustomer(Creditnumber);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return null;
            }

        }

        public CustomerDC editCustomer(Int32 Creditnumber, string template)
        {
            try
            {
                CustomerDBContext Customermanager = new CustomerDBContext();
                return Customermanager.editCustomer(Creditnumber, template);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return null;
            }

        }

        public void GenerateSeedData()
        {
            new CustomerDBContext().init();
        }

    }
}
