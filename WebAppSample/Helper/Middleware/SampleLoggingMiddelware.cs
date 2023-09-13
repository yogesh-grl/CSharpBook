namespace WebAppSample.Helper.Middleware
{
    public class SampleLoggingMiddelware
    {
        private readonly RequestDelegate _next;

        public SampleLoggingMiddelware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            object outputObj = new object();
            context.Items.TryGetValue("SampleKey", out outputObj);
            Console.WriteLine(outputObj);
            await _next(context);
        }

    }
}
