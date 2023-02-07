using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft;

namespace PatientEntryFE.Controllers
{
    public class PatientListController : Controller
    {
            Uri baseAddress = new Uri("https://localhost:7281/api/");
            HttpClient client;

            public PatientListController()
            {
                client = new HttpClient();
                client.BaseAddress = baseAddress;
            }
            public IActionResult Index()
            {
                List<PatientListController> patientlist = new List<PatientListController>();
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Customers").Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    patientlist = JsonConvert.DeserializeObject<List<PatientListController>>(data);

                }
                return View(patientlist);
            }
     }
 }
