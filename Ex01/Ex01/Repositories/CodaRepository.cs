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

                //https://coda.io/apis/v1/docs

                String url = _BASEURL + "/docs";
                string json = await client.GetStringAsync(url);

                try { 
                       

                       //json convert to list
                       if (json != null)
                        {
                           //json --> List Documents
                           var documents = JsonConvert.DeserializeObject<CodaDocument>(json);
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


    //2: GET list of Pages from 1 Document
     public static  async Task<List<CodaPage>>GetPagesAsync(String documentId)
        {
            using (HttpClient client = await GetClient())
            {
                //https://coda.io/apis/v1/docs/{docId}/pages

                String url = _BASEURL + $"/docs/{documentId}/pages";
                string json = await client.GetStringAsync(url);

                try
                {
                   
                    //json convert to list
                    if (json != null)
                    {
                        //json --> List Pages
                        var pages = JsonConvert.DeserializeObject<CodaPage>(json);
                        return pages.CodaPages;

                    }
                    else

                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }




        }




        //Get One Single Page



        //PUT UpDate a Page


        public async static Task UpdatePagesAsync(CodaPage updatedPage)
        {
            //deze methode voegt een nieuwe document toe 
            using (HttpClient client = await GetClient())
            {


                //https://coda.io/apis/v1/docs/{docId}/pages

                String url = _BASEURL + $"/docs/pages/{updatedPage.Id}";


                try
                {

                    //stap2 document moet meegestuurd worden met url
                    //
                    //Serialize c# object to JSON with newtonsoft
                    String json = JsonConvert.SerializeObject(updatedPage);

                    //build stringContent with serialized json object
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync(url, content);

                    //controle: is het gelukt?
                    if (response.IsSuccessStatusCode == false)
                    {

                        throw new Exception("Updaten van document niet geslaagd");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }



            }


        }

        //GET 1 Page by DocId,PageId


        public static async Task<CodaPageSingle> GetCodaPageByIdAsync(String documentId,String PageId)
        {
            using (HttpClient client = await GetClient())
            {
                //https://coda.io/apis/v1/docs/{docId}/pages/{PageId}

                String url = _BASEURL + $"/docs/{documentId}/pages/{PageId}";
                string json = await client.GetStringAsync(url);

                try
                {

                    //json convert to list
                    if (json != null)
                    {
                        //json -->1 page
                        

                        var page = JsonConvert.DeserializeObject<CodaPageSingle>(json);
                        return page;

                    }
                    else

                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }


        }
        



        //POST (add) new Document

        public async static Task AddDocumentsAsync(  string title)
        {
           using (HttpClient client = await GetClient()) 
           { 
               //voeg een niewe CodaDocument toe aan de documentId als parameter
               try
           {
               string url = _BASEURL + $"/docs";

                    //stap2 document moet meegestuurd worden met url
                    //document --> json
                    var postCodaDocument = new PostCodaDocument { Title = title , TimeZone= "Europe/Brussels" };
                    
               string json = JsonConvert.SerializeObject(postCodaDocument);
               HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
               var response = await client.PostAsync(url, content);

               //controle: is het gelukt?
               if (response.IsSuccessStatusCode == false)
               {

                   throw new Exception("Toevoegen van document niet geslaagd");
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           }

        }

        //DELETE  new Document


        public async static Task DeleteDocumentsAsync(string id)
        {
            using (HttpClient client = await GetClient())
            {
                //voeg een niewe CodaDocument toe aan de documentId als parameter
                try
                {
                    string url = _BASEURL + $"/docs/" + id;

                    var response =  client.DeleteAsync(url).Result;

                    //controle: is het gelukt?
                    if (response.IsSuccessStatusCode == false)
                    {

                        throw new Exception("Delete did not succeed");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        // GET Account INFO


        public static async Task <Account> GetAccountInfoAsync()
        {
            using (HttpClient client = await GetClient())
            {
                //https://coda.io/apis/v1/whoami

                string url = _BASEURL + "/whoami";
                
                try
                {
                    string json = await client.GetStringAsync(url);

                    Account account = JsonConvert.DeserializeObject<Account>(json);

                    return account;

                }
                catch (Exception ex)
                {

                    throw ex;
                }




            }


        }


        //Get Categories (list)

        public static async Task<List<Categories>> GetCategoriesAsync()
        {
            using (HttpClient client = await GetClient())
            {

                //https://coda.io/apis/v1/categories

                String url = _BASEURL + "/categories";
                string json = await client.GetStringAsync(url);

                try
                {


                    //json convert to list
                    if (json != null)
                    {
                        //json --> List Documents
                        var categories = JsonConvert.DeserializeObject<Categories>(json);
                        return categories.CodaCategories;

                    }
                    else

                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }


        }




    }
}
