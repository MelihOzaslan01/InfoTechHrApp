using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.Data;

namespace Layer.Business.User
{
    public class UserProcess
    {
        static DbInfoTechHrAppEntities Context = new DbInfoTechHrAppEntities();
        public bool Login(string Username, string Password, out string Message)
        {


            bool result = false;
            Message = "";

            //Lambda - linQ

            var KullaniciVerisi = (from Data in Context.TblKullanici where Data.KullaniciAdi == Username && Data.Sifre == Password select Data).SingleOrDefault();
            if (KullaniciVerisi == null)
            {
                Message = "Hatali bilgi girisi";
            }
            else
            {
                result = true;
            }

            return result;


        }
    }
}
