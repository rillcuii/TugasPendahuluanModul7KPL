using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CODE_TP_MODUL7
{
    public class DataMahasiswa_103082400033
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {

            string jsonString = File.ReadAllText("tp7_1_103082400033.json");
            DataMahasiswa_103082400033 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_103082400033>(jsonString);

            Console.WriteLine($"Nama {mahasiswa.nama} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }
}
