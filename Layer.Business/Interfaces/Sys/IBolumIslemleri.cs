using Layers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business.Interfaces.Sys
{
    internal interface IBolumIslemleri
    {
        List<SysBolum> Bolumler();
        List<SysBolum> Bolumler(string Metin);
        Nullable<bool> BolumEkle(string BolumAdi, out string Mesaj, out int BolumId);
        bool? BolumGuncelle(SysBolum Bolum, out string Mesaj);
        bool BolumSil(int BolumId, out string Mesaj);
    }
}
