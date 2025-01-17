using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductManagement.Application.Exceptions;

namespace ProductManagement.API.Filters;

public class ProductManagementExceptionHandler : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case UserNotFoundException:
                var userNotFound = new Error
                {
                    StatusCode = 404,
                    StatusPhrase = $"{context.Exception.Message}",
                    Timestamp = DateTime.Now
                };
                context.Result = new JsonResult(userNotFound) { StatusCode = 404 };
                break;
 

            case DataException:
                var repeatedData = new Error
                {
                    StatusCode = 409,
                    StatusPhrase = $"{context.Exception.Message}",
                    Timestamp = DateTime.Now
                };
                context.Result = new JsonResult(repeatedData) { StatusCode = 409 };
                break;

            case LoginFailedException:
                var logindata = new Error
                {
                    StatusCode = 409,
                    StatusPhrase = $"{context.Exception.Message}",
                    Timestamp = DateTime.Now
                };
                context.Result = new JsonResult(logindata) { StatusCode = 409 };
                break;
            default:
                var error = new Error
                {
                    StatusCode = 500,
                    StatusPhrase = $"{context.Exception.Message}",
                    Timestamp = DateTime.Now
                };
                context.Result = new JsonResult(error) { StatusCode = 500};
                break;
        }
    }
}