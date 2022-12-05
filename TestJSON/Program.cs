using System.Text.Json;
using System.Net.Http;
using System.Text;

namespace TestJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            HttpClient client = new HttpClient(httpClientHandler);
            var response = client.GetAsync("https://185.20.227.127/api/get_q.php").Result;
            string content = response.Content.ReadAsStringAsync().Result;
            //content = System.Text.RegularExpressions.Regex.Unescape(content);
            var result = JsonSerializer.Deserialize<Exam.Question>(content);
            Console.WriteLine(result);
        }
    }
}