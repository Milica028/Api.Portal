using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portal.BusinessModels;
using Portal.IBusinessLogic;

namespace Portal.BusinessLogic
{

    public class UserBL : IUserBL
    {
        public IList<AuthenticationUserRequest> GetList()
        {
            IList<AuthenticationUserRequest> customers = new List<AuthenticationUserRequest>();
            customers.Add(new AuthenticationUserRequest() { Name = "Nice customer", Address = "USA", Telephone = "123345456" });
            customers.Add(new AuthenticationUserRequest() { Name = "Good customer", Address = "UK", Telephone = "9878757654" });
            customers.Add(new AuthenticationUserRequest() { Name = "Awesome customer", Address = "France", Telephone = "34546456" });
            return customers;
        }
    }
}
