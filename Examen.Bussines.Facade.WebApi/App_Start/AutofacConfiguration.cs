using Autofac;
using Autofac.Integration.WebApi;
using Examen.Business.Autofac.Configuration;
using Examen.Business.Contract.Logic;
using Examen.Bussines.Contract.Logic;
using Examen.Bussines.Logic;
using Examen.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Examen.Bussines.Facade.WebApi.App_Start
{
    public static class AutofacConfiguration
    {
        public static IContainer Build(Assembly apiAssembly)
        {
            var builder = new ContainerBuilder();

			builder
				.RegisterApiControllers(apiAssembly);

			builder
				.RegisterType<DataRatesBl>()
				.As<IDataRatesBl>();
			builder
				.RegisterType<DataTransBl>()
				.As<IDataTransBl>();


			builder.RegisterModule(new CommonBuilder());

			
            return builder.Build();
        }
    }
}