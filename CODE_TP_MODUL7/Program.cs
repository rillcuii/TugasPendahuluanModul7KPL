using CODE_TP_MODUL7;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Output DataMahasiswa--");
        DataMahasiswa_103082400033 mhs = new DataMahasiswa_103082400033();
        mhs.ReadJSON();

        Console.WriteLine();

        Console.WriteLine("--Otput KuliahMahasiswa--");
        KuliahMahasiswa_103082400033 kuliah = new KuliahMahasiswa_103082400033();
        kuliah.ReadJSON();
    }
}
