using System;
using System.Runtime.Serialization;

namespace TemplateService.DataContracts
{
    [DataContract]
    public class TemplateDC 
    {
        private string _TextSample = string.Empty;
        private string _name = string.Empty;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string TextSample
        {
            get { return _TextSample; }
            set { _TextSample = value; }
        }

    }

}