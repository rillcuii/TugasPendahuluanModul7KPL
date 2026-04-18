using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CODE_TP_MODUL7
{
    public class MataKuliah
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }
    public class KuliahMahasiswa_103082400033
    {
        public List<MataKuliah> MataKuliah { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_2_103082400033.json");
            KuliahMahasiswa_103082400033 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_103082400033>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < kuliah.MataKuliah.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {kuliah.MataKuliah[i].kode} - {kuliah.MataKuliah[i].nama}");
            }
        }
    }
}
