using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
namespace Filezad
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> namesList = new List<string> { "Ali", "Qarib", "Akula" };

            string json = JsonConvert.SerializeObject(namesList);

            string filePath = @"C:\\Users\\hp\\OneDrive - Azerbaijan State Technical University\\Desktop\\jesonnn";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(json);
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
