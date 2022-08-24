using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentsGpa = new Dictionary<string, int>();
            studentsGpa.Add("Saleh", 84);
            studentsGpa.Add("Aysu", 96);
            studentsGpa.Add("Elvin", 94);
            studentsGpa.Add("Kenan", 79);

            foreach (var student in studentsGpa)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            foreach (KeyValuePair<string,int> kvp in studentsGpa)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine();

            foreach (var kvp in studentsGpa)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            if (!studentsGpa.ContainsKey("Fidan"))
            {
                studentsGpa.Add("Fidan", 97);
                Console.WriteLine("Fidan Point: "+studentsGpa["Fidan"]);
            }
            int result = 0;
            if (studentsGpa.TryGetValue("Saleh",out result))
            {
                Console.WriteLine("Saleh Point: " + result);
            }
            Console.WriteLine();
            studentsGpa["Saleh"] = 90;
            studentsGpa.Remove("Kenan");
            
            foreach (var kvp in studentsGpa)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine();
            Dictionary<string,string> Capital = new Dictionary<string, string>{{"Azerbaijan", "Baku"}, {"Turkey", "Ankara"},{"Germany", "Berlin"} };
            foreach (var kvp in Capital)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            if (Capital.ContainsValue("Baku"))
            {
                Console.WriteLine("Baku is exist");
            }
            else Console.WriteLine("Baku is not found");
            Capital.Clear();
            if (Capital.Count == 0) Console.WriteLine("Empty");
            Console.ReadKey();
        }
    }
}
