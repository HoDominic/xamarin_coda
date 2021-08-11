using Ex01.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
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
                String url = _BASEURL + "/docs";
                string json = await client.GetStringAsync(url);

                try { 
                       //https://coda.io/apis/v1/docs

                       //json convert to list
                       if (json != null)
                        {
                           //json --> List Documents
                           var documents = JsonConvert.DeserializeObject<Root>(json);
                           return documents.CodaDocuments;

                        }
                       else

                        {
                            return null;
                        }
                }catch(Exception ex)
                {
                    throw ex;
                }

            }


        }


    // GET list of Pages from 1 Document
    //public static Task<CodaPage>







      
    }
}
