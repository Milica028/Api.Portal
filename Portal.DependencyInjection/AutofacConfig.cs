using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Portal.BusinessLogic;
using Portal.IBusinessLogic;

namespace Portal.DependencyInjection
{
    public class AutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            // Create our Singletons
            builder.RegisterType<UserBL>().As<IUserBL>().InstancePerRequest();

        }
    }
}
