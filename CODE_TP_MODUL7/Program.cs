using System;
using CODE_TP_MODUL7; 

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103082400042 dataMhs = new DataMahasiswa103082400042();
        dataMhs.ReadJSON();

        KuliahMahasiswa103082400042 kuliah = new KuliahMahasiswa103082400042();
        kuliah.ReadJSON();
    }
}