using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
namespace CP.CustomerPortal.Service.Contract
{
    [ServiceContract]
    public interface ICPMembershipService
    {
        [OperationContract]
        MembershipUser CreateUser(string username, string password);

        [OperationContract]
        MembershipUser CreateUser(string username, string password, string email);

    }
}
