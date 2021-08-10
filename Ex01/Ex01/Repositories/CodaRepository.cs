using Ex01.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
       private   static async Task<HttpClient> GetClient()
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


        public  static async Task<List<CodaDocument>>GetDocumentsAsync()
        {
            using (HttpClient client = await GetClient()) 
            {
                //https://coda.io/apis/v1/docs

                String url = _BASEURL + "/docs";
                string json = await client.GetStringAsync(url);
                //json converteren naar list
                if (json != null)
                {
                    //json --> List Documents

                    //List<CodaDocument> documents = JsonConvert.DeserializeObject<List<CodaDocument>>(json);
                  //  return documents;


                    //deserialize object to JObject (< newtonsoft)
                    JObject fullObject = JsonConvert.DeserializeObject<JObject>(json);

                    //path to child token
                    JToken data = fullObject.SelectToken("item");

                    //this token will be deserialized to required object type
                    return data.ToObject<> ();

                }
                else
                {
                    return null;
                }



            }



        }




      
    }
}
