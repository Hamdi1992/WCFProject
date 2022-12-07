using System;
using System.Runtime.Serialization;

namespace ServiceCustomers.DataContracts
{
    [DataContract]
    public class CustomerDC 
    {
        private double _amount = 0;
        private string _name = string.Empty;
        private DateTime _duedate = new DateTime();
        private string _template = string.Empty;
        private long _Creditnumber = 0;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public double amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [DataMember]
        public DateTime dueDate
        {
            get { return _duedate; }
            set { _duedate = value; }
        }

        [DataMember]
        public string template
        {
            get { return _template; }
            set { _template = value; }
        }

        [DataMember]
        public long Creditnumber
        {
            get { return _Creditnumber; }
            set { _Creditnumber = value; }
        }

    }

}