using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CODE_TP_MODUL7
{

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    internal class KuliahMahasiswa_103082430001
    {
        public List<Course> courses { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_2_103082430001.json");
            var data = JsonSerializer.Deserialize<KuliahMahasiswa_103082430001>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
            }
        }
    }
}
