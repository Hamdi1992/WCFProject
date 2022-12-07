using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TemplateService.DataContracts;
using TemplateService.dbContexts;
using TemplateService.Models;
using static Mono.Security.X509.X520;

namespace TemplateService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TemplateService : ITemplateService
    {
        public TemplateDC addTemplate(string Name, string textSample, List<string> values)
        {
            try
            {
                TemplateDBContext TemplateManager = new TemplateDBContext();
                return TemplateManager.addTemplate(Name, textSample);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return null;
            }
        }

        public Boolean removeTemplate(string name)
        {
            try
            {
                TemplateDBContext TemplateManager = new TemplateDBContext();
                TemplateManager.removeTemplate(name);
                return TemplateManager.removeTemplate(name);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return false;
            }
        }

        public TemplateDC getTemplate(string name)
        {
            try
            {
                TemplateDBContext TemplateManager = new TemplateDBContext();
                return TemplateManager.getTemplate(name);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return null;
            }
        }

        public void GenerateSeedData()
        {
            new TemplateDBContext().init();
        }
    }
}
