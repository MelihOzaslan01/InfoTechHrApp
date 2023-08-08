using Layer.Business.Interfaces;
using Layer.Business.Interfaces.Sys;
using Layers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business
{
    public delegate void RxBenimDelegem(string Status);

    public class SysIslemleri : IOkulIslemleri,
                                  IDepartmanIsleleri,
                                  IBolumIslemleri,
                                  IDatabaseProcess
    {

        public event RxBenimDelegem BenimOlayim;

        /// <summary>
        /// Bu fonksiyon sistem tablosuna bolum eklemek için kullanılır.
        /// </summary>
        /// <param name="BolumAdi">Bölüm adı parametresi</param>
        /// <param name="Mesaj">Hata olması durumunda bu parametre nedenini bildirir</param>
        /// <param name="BolumId">Bölüm eklendikten sonra sana son eklenen BolumId döndürür.</param>
        /// <example>BolumEkle("IT", "Hata", 1)</example>
        /// <returns></returns>
        public Nullable<bool> BolumEkle(string BolumAdi, out string Mesaj, out int BolumId)
        {
            Nullable<bool> result = false;
            Mesaj = "";
            BolumId = 0;

            try
            {
                if (BenimOlayim != null)
                    BenimOlayim("Yeni başladı");

                CheckDbConnection(true);
                if (BenimOlayim != null)
                    BenimOlayim("Database' e baktım");
                SysBolum sysBolum = new SysBolum();
                if (BenimOlayim != null)
                    BenimOlayim("Nesne oluşturdum");
                sysBolum.BolumAdi = BolumAdi;
                Database.Connection.SysBolum.Add(sysBolum);
                Database.Connection.SaveChanges();
                if (BenimOlayim != null)
                    BenimOlayim("Kayıt Ettim");
                result = true;
                BolumId = sysBolum.BolumId;
            }
            catch (Exception ex)
            {
                Mesaj = ex.Message;
                if (BenimOlayim != null)
                    BenimOlayim("Hata aldım " + ex.Message);
            }
            if (BenimOlayim != null)
                BenimOlayim("Bitirdim");
            return result;
        }

        public bool? BolumGuncelle(SysBolum Bolum, out string Mesaj)
        {
            bool? result = false;
            Mesaj = "";
            try
            {
                CheckDbConnection(true);
                SysBolum BulunanKayit = (from data in
                                         Database.Connection.SysBolum
                                         where data.BolumId == Bolum.BolumId
                                         select data).SingleOrDefault();
                if (BulunanKayit != null)
                {
                    BulunanKayit.BolumAdi = Bolum.BolumAdi;
                    Database.Connection.SaveChanges();
                    result = true;
                }

            }
            catch (Exception ex)
            {
                Mesaj = ex.Message;
            }
            return result;
        }

        public List<SysOkul> Bolumler()
        {
            return (from data in Database.Connection.SysOkul orderby data.Okul select data).ToList();
        }

        public List<SysOkul> Bolumler(string Metin)
        {
            return
                (from data in Database.Connection.SysOkul
                 where data.Okul.Contains(Metin)
                 select data).ToList();
        }

        public bool BolumSil(int BolumId, out string Mesaj)
        {
            Mesaj = "";
            return false;
        }


        public bool DepartmanEkle(string BolumAdi, out string Mesaj, out int BolumId)
        {
            Mesaj = "";
            BolumId = 0;
            return false;
        }

        public bool DepartmanGuncelle(SysDepartman departman, out string Mesaj)
        {
            Mesaj = "";
            return false;
        }

        public bool DepartmanSil(int departmanId, out string Mesaj)
        {
            Mesaj = "";
            return false;
        }

        public bool OkulEkle(string okulAdi, out string Mesaj, out int okulId)
        {
            Mesaj = "";
            okulId = 0;
            return false;
        }

        public bool OkulGuncelle(SysOkul okul, out string Mesaj)
        {
            Mesaj = "";
            return false;
        }

        public bool OkulSil(int okulId , out string Mesaj)
        {
            Mesaj = "";
            return false;
        }

        List<SysDepartman> IDepartmanIsleleri.Bolumler()
        {
            return
                (from data in Database.Connection.SysDepartman orderby data.DepartmanAdi select data).ToList();
        }

        List<SysDepartman> IDepartmanIsleleri.Bolumler(string Metin)
        {
            return
                (from data in Database.Connection.SysDepartman
                 where data.DepartmanAdi.Contains(Metin)
                 select data).ToList();
        }

        List<SysBolum> IBolumIslemleri.Bolumler()
        {
            return
                (from data in Database.Connection.SysBolum 
                 orderby data.BolumAdi select data).ToList();
        }

        List<SysBolum> IBolumIslemleri.Bolumler(string Metin)
        {
            return
                (from data in Database.Connection.SysBolum
                 where data.BolumAdi.Contains(Metin)
                 select data).ToList();
        }

        public bool CheckDbConnection()
        {
            return
                Database.Connection.Database.Connection.State == global::System.Data.ConnectionState.Open ? true : false;
        }

        /// <summary>
        ///Bu method database bağlantısı yoksa, otomatik bağlantı parametresini true vermen durumunda otomatik olarak veri tabanına bağlantı sağlar.
        /// </summary>
        /// <example>CheckDbConnection(true);</example>
        /// <param name="AutoConnect">True/False</param>
        public void CheckDbConnection(bool AutoConnect)
        {
            void ConnectDb()
            {
                Database.Connection.Database.Connection.Open();
            }
            switch (Database.Connection.Database.Connection.State)
            {
                case global::System.Data.ConnectionState.Closed:
                    ConnectDb();
                    break;
                case global::System.Data.ConnectionState.Broken:
                    ConnectDb();
                    break;
                default:
                    break;
            }

        }

        public void DbConnect()
        {
            Database.Connection.Database.Connection.Open();
        }

        public void DbDisconnect()
        {
            Database.Connection.Database.Connection.Close();
        }

       
    }
}
