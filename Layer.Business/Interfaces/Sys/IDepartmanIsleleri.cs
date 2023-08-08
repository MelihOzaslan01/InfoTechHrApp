using Layers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business.Interfaces.Sys
{
    internal interface IDepartmanIsleleri
    {
        List<SysDepartman> Bolumler();
        List<SysDepartman> Bolumler(string Metin);
        bool DepartmanEkle(string BolumAdi, out string Mesaj, out int BolumId);
        bool DepartmanGuncelle(SysDepartman Bolum, out string Mesaj);
        bool DepartmanSil(int BolumId, out string Mesaj);
    }
}
