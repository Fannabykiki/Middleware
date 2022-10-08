using System.Diagnostics;
using System.Text;
namespace Rookies.Middlewares
{
    public class LogginMiddlewares
    {
        private readonly RequestDelegate _next;
        public LogginMiddlewares(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;
            string requestInfo = "Scheme: " + request.Scheme +
            "\tHost: \t" + request.Host +
            "\tPath: \t" + request.Path +
            "\tQueryString: \t" + request.QueryString +
            "\tBody: \t" + request.Body;
            Debug.WriteLine(requestInfo);
            SaveFile.WriteToFileByStream("D:\\Rookies", "RequestLog.txt", requestInfo);
            await _next(context);
        }
    }
}