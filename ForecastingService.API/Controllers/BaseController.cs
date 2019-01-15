using ForecastingService.Logic;
using ForecastingService.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ForecastingService.API.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IOptions<ServiceConfiguration> _configuration;

        public BaseController(IOptions<ServiceConfiguration> configuration)
        {
            _configuration = configuration;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            try
            {
                var result = await next();

                if (result.Exception != null && !result.ExceptionHandled)
                {
                    result.ExceptionHandled = true;
                    throw result.Exception;
                }
            }
            catch (LogicException le)
            {
                context.HttpContext.Response.StatusCode = (int)le.ErrorCode;
            }
            catch (Exception)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
        }
    }
}
