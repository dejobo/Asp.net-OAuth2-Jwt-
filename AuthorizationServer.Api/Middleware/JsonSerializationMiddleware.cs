using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppFunc = System.Func<
    System.Collections.Generic.IDictionary<string, object>, 
    System.Threading.Tasks.Task>;

namespace AuthorizationServer.Api.Middleware
{
    public class JsonSerializationMiddleware
    {
        private AppFunc _next;
        public JsonSerializationMiddleware(AppFunc next)
        {
            _next = next;
        }


    }
}