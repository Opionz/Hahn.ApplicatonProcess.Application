using Hahn.ApplicatonProcess.July2021.Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Hahn.ApplicatonProcess.July2021.Web.Filter
{
    public class ValidationMiddleware : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.Where(v => v.Errors.Count > 0)
                        .SelectMany(v => v.Errors)
                        .Select(v => v.ErrorMessage)
                        .ToList();

                ResponseModel r = new ResponseModel
                {
                    IsSuccess = false,
                    MainErrorMessage = "An error occured while validing your input. Please check your inputs and try again.",
                    Errors = errors
                };

                context.Result = new JsonResult(r)
                {
                    StatusCode = 400
                };
            }
        }
    }
}
