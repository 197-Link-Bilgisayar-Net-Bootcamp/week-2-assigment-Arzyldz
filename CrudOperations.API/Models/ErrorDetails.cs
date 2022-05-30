using Hangfire.Annotations;
using System.Net;

namespace CrudOperations.API.Models
{
    public class ErrorDetails
    {
        public HttpStatusCode StatusCode { [UsedImplicitly] get; set; }

        public string Message { [UsedImplicitly] get; set; }
    }

    public class ExtendedErrorDetails : ErrorDetails
    {
        public string StackTrace { [UsedImplicitly] get; set; }
    }
}
