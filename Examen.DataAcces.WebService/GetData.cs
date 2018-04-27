using Examen.Common.Contract.Logic.LoggerAdapter;
using Examen.Common.Logic;
using Examen.Common.Logic.LoggerAdapter;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DataAcces.WebServices
{
    public class GetData : IGetData
    {
		private readonly ILogger logger = Log4NetConfiguration.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public async Task<List<DataTrans>> GetDataTrans()
		{
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(WebService.Resources.Connection.url);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			var response = Task.FromResult(client.GetAsync(WebService.Resources.Connection.transaction)
				.GetAwaiter()
				.GetResult()).Result;
			var result = Task.FromResult(response.Content.ReadAsAsync<List<DataTrans>>()
				.GetAwaiter()
				.GetResult())
				.Result;
			return result;
			
		}

		public async Task<List<DataRates>> GetDataRates()
		{
			logger.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(WebService.Resources.Connection.url);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			var response = Task.FromResult(client.GetAsync(WebService.Resources.Connection.rates)
				.GetAwaiter()
				.GetResult()).Result;
			var result = Task.FromResult(response.Content.ReadAsAsync<List<DataRates>>()
				.GetAwaiter()
				.GetResult())
				.Result;
			return result;

		}
	}
}
