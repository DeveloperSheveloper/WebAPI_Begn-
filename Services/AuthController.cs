using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;

namespace LoginAPI.Services
{
    public class AuthController : ApiController //Created a Base AUthentication Helper Controller to handle HTTP for Post and Get Repsonse
    {
        string BaseApiUrl = System.Configuration.ConfigurationManager.AppSettings["APIURL"]; // API URL for localhost => base url :: web Config file 

        public async Task<HttpResponseMessage> apiGetResponse(string apiUrlString, object parameters = null)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseApiUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if(parameters != null)
            {
                //client-side
            }

            HttpResponseMessage resMsg = await client.GetAsync(apiUrlString);
            return resMsg;
        }

        public async Task<HttpResponseMessage> apiPostResponse(string apiUrlString, object parameters = null)
        {

            HttpResponseMessage responseMsg = new HttpResponseMessage();

            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseApiUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (parameters != null)
            {
                string Json=JsonConvert.SerializeObject(parameters);
                System.Diagnostics.Debug.WriteLine("Request JSON: " + Json);
                var paramToJson=new StringContent(Json,System.Text.Encoding.UTF8,"application/json");
                responseMsg = await client.PostAsync(apiUrlString, paramToJson);
            }
            else 
            {
                var jsonErr = new StringContent(string.Empty, System.Text.Encoding.UTF8, "application/json");
                responseMsg = await client.PostAsync(apiUrlString, jsonErr);
            }
            string responseText = await responseMsg.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine("Response Text: " + responseText); // See the real error
            client.Dispose();
            return responseMsg;
        }
    }
}
