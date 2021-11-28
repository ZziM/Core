using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Core.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public ILogger Logger { get; }

        public LoggerMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            Logger = logger;
        }
    }
}
