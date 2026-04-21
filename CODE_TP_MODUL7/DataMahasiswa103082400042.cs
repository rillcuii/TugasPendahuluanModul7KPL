using System;
using System.IO;
using System.Text.Json;

namespace CODE_TP_MODUL7
{
    class NamaLengkap
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    class DetailMahasiswa
    {
        public NamaLengkap nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa103082400042
    {
        public void ReadJSON()
        {
            string filePath = "tp7_103082400042.json";

            try
            {
                // Membaca seluruh teks dari file JSON
                string jsonString = File.ReadAllText(filePath);

                // Proses Deserialisasi (Mengubah teks JSON menjadi Objek C#) 
                DetailMahasiswa mhs = JsonSerializer.Deserialize<DetailMahasiswa>(jsonString);

                // Print hasil sesuai format instruksi Modul 7 
                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (Exception e)
            {
                Console.WriteLine("File JSON tidak ditemukan atau format salah! Error: " + e.Message);
            }
        }
    }
}