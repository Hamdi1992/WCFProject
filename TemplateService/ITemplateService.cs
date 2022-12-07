using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TemplateService.DataContracts;

namespace TemplateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITemplateService
    {
        [OperationContract]
        TemplateDC addTemplate(string Name, string textSample, List<string> values);

        [OperationContract]
        Boolean removeTemplate(string name);

        [OperationContract]
        TemplateDC getTemplate(string name);

        [OperationContract]
        void GenerateSeedData();
    }
}
