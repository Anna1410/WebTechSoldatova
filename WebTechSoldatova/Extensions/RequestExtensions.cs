using Microsoft.AspNetCore.Http;

namespace WebTechSoldatova.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request
                .Headers["x-requested-with"]
                .Equals("XMLHttpRequest");
        }
    }
}
