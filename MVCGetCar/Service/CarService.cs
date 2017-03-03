using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCGetCar.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace MVCGetCar.Service
{
    public class CarService
    {
        readonly string uri = "https://mobiledev.sunovacu.ca/api/Values/GetCars";

        public List<Car> GetCars()
        {

            using (WebClient webClient = new WebClient())
            {

                return JsonConvert.DeserializeObject<List<Car>>(
                    webClient.DownloadString(uri)
                );
            }
        }

        public async Task<List<Car>> GetCarsAsync()
        {

            using (HttpClient httpClient = new HttpClient())
            {

                return JsonConvert.DeserializeObject<List<Car>>(
                    await httpClient.GetStringAsync(uri)
                );
            }
        }
    }
}