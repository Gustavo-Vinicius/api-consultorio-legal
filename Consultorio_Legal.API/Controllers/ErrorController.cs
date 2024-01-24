using System.Diagnostics;
using Consultorio_Legal.CORE.SHARED.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio_Legal.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("error")]
        public ErrorResponse Error()
        {
         
            Response.StatusCode = 500;

            var idError = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
            return new ErrorResponse(idError, HttpContext?.TraceIdentifier);
        }
    }
}