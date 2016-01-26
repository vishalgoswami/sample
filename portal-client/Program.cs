using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PortalClient;

namespace portal_client
{
    class Program
    {
        private static string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private static string tenant = ConfigurationManager.AppSettings["ida:Tenant"];
        private static string clientId = ConfigurationManager.AppSettings["ida:ClientId"];
        private static Uri redirectUri = new Uri(ConfigurationManager.AppSettings["ida:RedirectUri"]);
        
        static string authority = String.Format(CultureInfo.InvariantCulture, aadInstance, tenant);
        private static string apiResourceId = ConfigurationManager.AppSettings["ApiResourceId"];
        private static string apiBaseAddress = ConfigurationManager.AppSettings["ApiBaseAddress"];
        
        private static HttpClient httpClient = new HttpClient();
        private static AuthenticationContext authContext = null;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.getToken();
            //Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        private async void getToken()
        {
            authContext = new AuthenticationContext(authority);
            AuthenticationResult authResult = authContext.AcquireToken(apiResourceId, clientId, redirectUri);
            string token = authResult.AccessToken;
            //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            //HttpResponseMessage response = await httpClient.GetAsync(apiBaseAddress + "/api/values");
            //string responseString = await response.Content.ReadAsStringAsync();
            //Console.WriteLine("Response = " , responseString);


            PortalApiApp apiapp = new PortalApiApp();
            apiapp.HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var res1 = apiapp.Values.Get();
            var res2 = apiapp.Values.GetById(1);
            Console.WriteLine("response=" , res1);

        }
    }
}
