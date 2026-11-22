using System.Diagnostics;

namespace MVC1.custommadleware
{
    public class RequestMadleWare
    {
        public class RequestTimingMiddleware
        {
            private readonly RequestDelegate _next;

            public RequestTimingMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task InvokeAsync(HttpContext context)
            {
                var watch = Stopwatch.StartNew();
                await _next.Invoke(context);

                watch.Stop();
                Console.WriteLine($"{context.Request.Path}-{watch.ElapsedMilliseconds}as");
            }
        }
    }
}
