using Microsoft.AspNetCore.Http;

namespace connections.Model
{
    public static class Extension{
        public static void ApplicationError(this HttpResponse response, string message){
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers","Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin","*");                        
        }
    }
}