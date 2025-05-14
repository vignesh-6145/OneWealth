using System;

using Serilog.Context;

namespace OneWealth.API.Middleware;

public class RequestLogContextMiddleware
{
    private readonly RequestDelegate _next;
    public RequestLogContextMiddleware(RequestDelegate next){
        _next = next;
    }
    public Task InvokeAsync(HttpContext context){
        
        using (LogContext.PushProperty("CorrelationId", context?.TraceIdentifier)){
            return _next(context);
        }
    }
}
