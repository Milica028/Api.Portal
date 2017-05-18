using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portal.BusinessModels;

namespace Portal.IBusinessLogic
{
    public interface IUserBL
    {
         IList<AuthenticationUserRequest> GetList();
    }
}
