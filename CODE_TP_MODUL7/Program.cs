using CODE_TP_MODUL7;
using System;

namespace CODE_TP_MODUL7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103082430001 mhs = new DataMahasiswa_103082430001();

            mhs.ReadJSON();

            KuliahMahasiswa_103082430001 kuliah = new KuliahMahasiswa_103082430001();

            kuliah.ReadJSON();
        }
    }
}