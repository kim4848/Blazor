using System;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;



namespace test.Data
{

    public class ChuckNorrisService
    {
        public ChuckNorris GetJoke()
        {
            var client = new RestClient("https://api.chucknorris.io/jokes/random");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "api.chucknorris.io");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.16.3");
            IRestResponse response = client.Execute(request);

            var result=Newtonsoft.Json.JsonConvert.DeserializeObject<ChuckNorris>(response.Content);
            return result;
        }
    }

}