using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace CarParkAvailabilityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Carpark_Data> carpark_Data = new List<Carpark_Data>();
            Console.WriteLine("{0,-25} {1,-25} {2,-25} {3,-25}", "carpark_number", "total_lots", "lot_type", "lots_available");
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.data.gov.sg");
                Task<HttpResponseMessage> responseTask = client.GetAsync("/v1/transport/carpark-availability");
                responseTask.Wait();
                HttpResponseMessage result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    string data = readTask.Result;
                    Rootobject rootobject = JsonConvert.DeserializeObject<Rootobject>(data);
                    List<Item> item = rootobject.Items;
                    foreach (Item items in item)
                    {
                        carpark_Data = items.Carpark_data;
                        foreach (Carpark_Data carpark_datas in carpark_Data)
                        {
                            List<Carpark_Info> carpark_Info = carpark_datas.Carpark_info;
                            foreach (Carpark_Info carpark_info in carpark_Info)
                            {
                                if (carpark_info.Lots_available == null)
                                {
                                    continue;
                                }
                                else if (Convert.ToInt32(carpark_info.Lots_available) <= 10 && Convert.ToInt32(carpark_info.Lots_available) >= 1)
                                {
                                    Console.WriteLine("{0,14} {1,21} {2,23} {3,31}", carpark_datas.Carpark_number, carpark_info.Total_lots, carpark_info.Lot_type, carpark_info.Lots_available);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
