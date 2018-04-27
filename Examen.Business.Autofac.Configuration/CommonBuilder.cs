using Autofac;
using Examen.Business.Contract.Logic;
using Examen.Bussines.Logic;
using Examen.DataAcces.WebServices;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using Examen.DataAccess.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Business.Autofac.Configuration
{
    public class CommonBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
			builder
				.RegisterType(typeof(RedisDao))
				.As(typeof(IGetRedis))
				.As(typeof(ISetRedis));

			builder
				.RegisterType(typeof(GetData))
				.As(typeof(IGetData));

			base.Load(builder);
		
        }
    }
}
