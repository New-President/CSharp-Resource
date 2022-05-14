using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace BookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            Console.WriteLine("{0,2}  {1,13}  {2,-65}  {3,-19} {4,5} {5,11}", "ID", "ISBN", "Title", "Author", "No. of Pages", "Quantity");
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://ictonejourney.com");
                Task<HttpResponseMessage> responseTask = client.GetAsync("/api/books");
                responseTask.Wait();
                HttpResponseMessage result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    string data = readTask.Result;
                    bookList = JsonConvert.DeserializeObject<List<Book>>(data);
                    foreach (Book b in bookList)
                    {
                        Console.WriteLine("{0,2}  {1,13}  {2,-65}  {3,-25}  {4,5}  {5,10}", b.Id, b.Isbn, b.Title, b.Author, b.Pages, b.Qty);
                    }
                }
            }
        }
    }
}
