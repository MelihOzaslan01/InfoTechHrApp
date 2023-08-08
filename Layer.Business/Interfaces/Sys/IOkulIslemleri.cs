using Layers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business.Interfaces.Sys
{
    internal interface IOkulIslemleri
    {
        List<SysOkul> Bolumler();
        List<SysOkul> Bolumler(string Metin);
        bool OkulEkle(string BolumAdi, out string Mesaj, out int BolumId);
        bool OkulGuncelle(SysOkul Bolum, out string Mesaj);
        bool OkulSil(int BolumId, out string Mesaj);
    }
}
