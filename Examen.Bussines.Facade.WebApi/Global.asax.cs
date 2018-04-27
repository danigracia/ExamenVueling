using Autofac;
using Autofac.Integration.WebApi;
using Examen.Business.Autofac.Configuration;
using Examen.Business.Contract.Logic;
using Examen.Bussines.Contract.Logic;
using Examen.Bussines.Facade.WebApi.App_Start;
using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic.LoggerAdapter;
using Examen.DataAccesa.Contract.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Examen.Bussines.Facade.WebApi
{
    /// <summary>
    /// 
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
		private readonly ILogger logger = Log4NetConfiguration.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		/// <summary>
		/// 
		/// </summary>
		protected void Application_Start()
        {
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			var container = AutofacConfiguration.Build(Assembly.GetExecutingAssembly());

			GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            GlobalConfiguration.Configure(WebApiConfig.Register);

			var getData = container.Resolve<IGetData>();
			getData.GetDataRates();
			getData.GetDataTrans();
			


		}
    }
}
