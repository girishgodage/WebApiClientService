using System.Net;
using System.Net.Http;

namespace GGSoftware.ApiClientService
{
    public class HttpRequestResult<T>
    {
        public HttpResponseMessage HttpResponse
        {
            get;
            internal set;
        }
        public bool IsSucceded
        {
            get
            {
                return this.HttpResponse.IsSuccessStatusCode;
            }
        }
        public HttpStatusCode StatusCode
        {
            get
            {
                return this.HttpResponse.StatusCode;
            }
        }
        public T Result
        {
            get;
            internal set;
        }
        public HttpRequestResult(HttpResponseMessage response, T responseObject)
        {
            this.HttpResponse = response;
            this.Result = responseObject;
        }
    }
}
