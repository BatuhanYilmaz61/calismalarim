using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıKredi4
{
    internal class LoginLogin
    {
        static async Task Main(string[] args)
        {
            var options = new RestClientOptions("https://api.yapikredi.com.tr")
            {
                MaxTimeout = -1,
                FollowRedirects = false,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/auth/oauth/v2/token", Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("scope", "scope");
            request.AddParameter("client_secret", "207d12befa5a4b64b0a535332fe8d566");
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", "l7xxa258dc3820364eb58aea30bc7cab209f");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
