using CP.CoreWeb.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.WebModules.View.UserView
{
    public interface IUserPresenter
    {
        string SucccessMessage { get; set; }

        string ErrorMessage { get; set; }

        UserInfo User { get; set; }

        List<UserInfo> Users { get; set; }
    }
}
