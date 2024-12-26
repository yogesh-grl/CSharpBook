﻿namespace WebAppSample.Helper.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //Console.WriteLine($"Request : {context.Request.Method} {context.Response}");
            context.Items["SampleKey"] = "SampleData";
            await _next(context);
        }
    }
}
