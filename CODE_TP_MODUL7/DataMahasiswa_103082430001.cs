using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CODE_TP_MODUL7
{
    internal class DataMahasiswa_103082430001
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("tp7_1_103082430001.json");
            var data = JsonSerializer.Deserialize<DataMahasiswa_103082430001>(jsonString);

            Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
