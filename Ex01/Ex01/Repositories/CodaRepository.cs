using Ex01.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Ex01.Models.CodaDocumentTest;

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

            //BEARER TOKEN 
            client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", "f69b44ef-0585-4ce0-88ac-33dc3e81829d");

            return client;

        }

        //Authentication, not important




        //GET list of Documents
        //API documentation of this request: https://coda.io/developers/apis/v1#operation/listDocs

        //Paste this in POSTMAN : https://coda.io/apis/v1/docs
        


        public static async Task<List<CodaDocument>>GetDocumentsAsync()
        {
            using (HttpClient client = await GetClient()) 
            {
                //https://coda.io/apis/v1/docs

                String url = _BASEURL + "/docs";
                string json = await client.GetStringAsync(url);
                //json convert to list
                if (json != null)
                {
                    //json --> List Documents

                    //HOW I NORMALLY WORK

                    // 1:  I deserialize List of Objects from JSON and return it.
                    //2: I test/call the list in --> Mainpage.xaml.cs (!)

                    // normal code no nested object (doesn't work because it's nested in this API!)
                    //List<CodaDocument> documents = JsonConvert.DeserializeObject<List<CodaDocument>>(json);
                    //return documents;




                    //code nested Object(?)
                    //Here I am stuck
                    // want the same as above: A list of objects which I can test in Mainpage.xaml.cs




                    //my own code from trying.. can delete if you want

                    /*
                    deserialize object to JObject (< newtonsoft)(?)
                    JObject fullObject = JsonConvert.DeserializeObject<JObject>(json);

                    path to child token(?)
                    JToken data = fullObject.SelectToken("items");

                    this token will be deserialized to required object type (?)
                    return data.ToObject<Task<List>>();
                    */




                }
                else
                {
                    return null;
                }



            }



        }




      
    }
}
