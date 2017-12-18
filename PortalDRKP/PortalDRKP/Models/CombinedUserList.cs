using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDRKP.Models
{
    public class CombinedUserList
    {
        public List<User1C> list1C { get; set; }
        public List<UserCRM> listCRM { get; set; }
        public List<UserSpr> listSpr { get; set; }
        public AbsUser absuser { get; set; }
    }

    public class AbsUser
    {
        public string RUfirstname { get; set; }
        public string RUlastname { get; set; }
        public string ENfirstname { get; set; }
        public string ENlastname { get; set; }
        public string domainname { get; set; }
        public string mail { get; set; }
        public string idsprav { get; set; }
        public string id1c { get; set; }
        public string idcrm { get; set; }
        public string staffcode { get; set; }
        public string empdate { get; set; }
        public string kickdate { get; set; }
    }
}