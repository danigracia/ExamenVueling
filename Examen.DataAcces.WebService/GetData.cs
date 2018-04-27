using Examen.Common.Logic;
using Examen.DataAccesa.Contract.WebServices;
using Examen.DataAccess.Contract.Redis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DataAcces.WebServices
{
    public class GetData : IGetData
    {
		
		public async Task<List<DataTrans>> GetDataTrans()
		{
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
