using System;
using System.ServiceModel;
using ServiceCustomers.DataContracts;

namespace ServiceCustomers_
{
    [ServiceContract]
    public interface ICusServ
    {
        [OperationContract]
        CustomerDC addCustomer(string Name, DateTime dueDate, Int64 amount, Int32 Creditnumber, Int32 phonenbr,string template);

        [OperationContract]
        Boolean removeCustomer(Int32 Creditnumber);

        [OperationContract]
        CustomerDC getCustomer(Int32 Creditnumber);

        [OperationContract]
        CustomerDC editCustomer(Int32 Creditnumber, string template);
        [OperationContract]
        void GenerateSeedData();
    }

}
