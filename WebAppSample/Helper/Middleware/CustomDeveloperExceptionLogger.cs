namespace WebAppSample.Helper.Middleware
{
    public class CustomDeveloperExceptionLogger
    {
        private RequestDelegate _next;

        private IWebHostEnvironment _builder;

        private ILogger _logger;
        public CustomDeveloperExceptionLogger(RequestDelegate next, IWebHostEnvironment builder, ILogger logger)
        {
            _next = next;
            _builder = builder;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context); // Execute the next middleware
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");

                if (_builder.IsDevelopment())
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync("Unexpected error" + ex);
                }
                else
                {
                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsync("Unexpected Served Error");
                }
            }
        }
    }
}
