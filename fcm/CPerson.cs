using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fcm
{
    public class CCommunicationDetails
    {
        public string city { set; get; }
        public string street { set; get; }
        public UInt32 houseNo { set; get; }
        public UInt32 phoneNo1 { set; get; }
        public UInt32 phoneNo2 { set; get; }
        public string email { set; get; }
        //public string Display { get; set; }
    } 
    
    
    public class CPerson
    {
        public CPerson() {}
        public CPerson(string firstName, string lastName, UInt32 id) 
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
        }
        public CPerson(string firstName, string lastName, UInt32 id, CCommunicationDetails commDetails)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            CommDetails = commDetails;
        }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public UInt32 ID { set; get; }
        public DateTime birthDay { set; get; }
        public UInt32 hieght { set; get; }
        public UInt32 wieght { set; get; }
        public CCommunicationDetails CommDetails { set; get; }

        public string DisplayName 
        {
            get 
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
