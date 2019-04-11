using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using CP.CustomerPortal.Service.Contract;

namespace CP.CustomerPortal.Service
{
    public class CPMembershipService : ICPMembershipService
    {
        public MembershipUser CreateUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public MembershipUser CreateUser(string username, string password, string email)
        {
            throw new NotImplementedException();
        }
    }
}
