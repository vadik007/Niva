using Nancy.Responses.Negotiation;
using Niva.Model; 
namespace Niva.Services
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
                { 
                    var response = Response.AsJson( new User[]
                    {new User{Name = "Vasia",Birthday = "18 apr 1987"},
                        new User{Name = "Pete",Birthday = "18 apr 1987"},
                        new User{Name = "Jane",Birthday = "18 apr 1987"}}
                        );

                    response.Headers.Add("Access-Control-Allow-Origin", "*");
                    response.Headers.Add("Access-Control-Allow-Methods", "POST,GET,DELETE,PUT,OPTIONS");
                    //response.Headers.Add("Access-Control-Allow-Credentials", "true");
                    response.Headers.Add("Access-Control-Allow-Headers", "Accept,Origin,Content-type,MY_HEADER");
                    response.Headers.Add("Access-Control-Expose-Headers", "Accept,Origin,Content-type,MY_HEADER");
                    return response;
                };
        }
    }
}