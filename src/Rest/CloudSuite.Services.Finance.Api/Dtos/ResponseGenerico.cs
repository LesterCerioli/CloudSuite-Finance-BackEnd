using System.Dynamic;
using System.Net;

namespace CloudSuite.Services.Finance.Api.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode codigohttp {  get; set; } 
        public T? ReturnData { get; set; } 
        public ExpandoObject? ReturnErrror { get; set; }
    }
}
