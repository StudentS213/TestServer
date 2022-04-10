using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TestShared;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient httpClient = new()
            {
                BaseAddress = new("http://localhost:5000")
            };

            var students = await httpClient.GetFromJsonAsync<StudentDto[]>("students/all");
            StudentDto student = new()
            {
                Surname = "Иванов",
                Name = "Иван",
                Age = 0
            };
           
            var responce = await httpClient.PostAsJsonAsync("students", student);
            student = await responce.Content.ReadFromJsonAsync<StudentDto>();
            student.Age = 20;
            await httpClient.PutAsJsonAsync("students", student);

           
        }
    }
}
