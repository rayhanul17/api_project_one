using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleApi.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        #region V1
        // context.Result = new ObjectResult(new{ error = "An error occured provided by filter"})
        // {
        //     StatusCode = 500
        // };
        #endregion

        #region V2
        var problemDetails = new ProblemDetails
        {
            Type = "Unknwon for raj",
            Title = "An error occurred while processing your request by filter.",
            Status = (int)HttpStatusCode.InternalServerError
        };
        #endregion
        
        context.Result = new ObjectResult(problemDetails);
        context.ExceptionHandled = true;
    }
}
