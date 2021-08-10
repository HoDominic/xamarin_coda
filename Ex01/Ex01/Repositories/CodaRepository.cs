using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Repositories
{
    public class CodaRepository
    {

        //define base URL
        private const String _BASEURL = "https://coda.io/apis/v1";
        private const String _Token = "f69b44ef-0585-4ce0-88ac-33dc3e81829d";




        //prepare HttpClient
        private static async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            //BEARER TOKEN ?
            client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", "f69b44ef-0585-4ce0-88ac-33dc3e81829d");

            return client;

        }


        //GET list of Documents
        //https://coda.io/apis/v1/docs








    }
}
