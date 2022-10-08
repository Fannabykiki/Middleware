namespace Rookies.Middlewares
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseLogginMiddleware(this IApplicationBuilder builder)
        {           
            return builder.UseMiddleware<LogginMiddlewares>();
        }
    }
}