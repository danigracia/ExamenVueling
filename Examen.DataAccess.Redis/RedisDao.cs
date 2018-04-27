using Examen.Common.Logic;
using Examen.DataAccess.Contract.Redis;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DataAccess.Redis
{
    public class RedisDao : ISetRedis, IGetRedis
    {
        private readonly IDatabase _redis;
        public RedisDao()
        {
            this._redis = RedisConfiguration.RedisCache;
        }
		public List<DataRates> AddRates(List<DataRates> dataRates, string key)
		{
			this._redis.StringSet(key, JsonConvert.SerializeObject(dataRates));
            return this.GetRates(key);
        }

		public List<DataTrans> AddTrans(List<DataTrans> dataTrans, string key)
		{
			
			this._redis.StringSet(key, JsonConvert.SerializeObject(dataTrans));
			return this.GetTrans(key);
		}

		public List<DataRates> GetRates(string key)
        {
            return JsonConvert.DeserializeObject<List<DataRates>>(this._redis.StringGet(key));
        }
		public List<DataTrans> GetTrans(string key)
		{
			return JsonConvert.DeserializeObject< List<DataTrans>>(this._redis.StringGet(key));
		}
	}
}
