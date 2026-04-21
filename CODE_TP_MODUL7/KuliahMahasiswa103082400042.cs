using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CODE_TP_MODUL7
{
    class MataKuliah
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }

    // Class pembungkus utama JSON
    class DaftarMataKuliah
    {
        public List<MataKuliah> mata_kuliah { get; set; }
    }

    public class KuliahMahasiswa103082400042
    {
        public void ReadJSON()
        {
            string filePath = "tp7_2_103082400042.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);

                // Deserialisasi ke objek C#
                DaftarMataKuliah daftar = JsonSerializer.Deserialize<DaftarMataKuliah>(jsonString);

                Console.WriteLine("\nDaftar mata kuliah yang diambil:");
                int i = 1;
                foreach (var mk in daftar.mata_kuliah)
                {
                    Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error lagi nih Dra: " + e.Message);
            }
        }
    }
}