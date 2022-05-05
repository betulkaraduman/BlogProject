using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44345/api/Default");
            var jsonString = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<EmployeeClass>>(jsonString);
            return View(values);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeClass employee)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44345/api/Default", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("/index");
            }
            return View(employee);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44345/api/Default/"+id);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<EmployeeClass>(jsonString);
                return View(values);
            }
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> UpdateEmployee(EmployeeClass employee)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(employee);
            var content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var response = await httpClient.PutAsync("https://localhost:44345/api/Default/"+employee.Id,content);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<EmployeeClass>>(jsonString);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync("https://localhost:44345/api/Default/" + id);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<EmployeeClass>(jsonString);
                return RedirectToAction("Index");
            }
            return View();
        }
        public class EmployeeClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
