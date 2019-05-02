using LenaSoftwareFMP.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftwareFMP.BLL
{
    public class LoginManager
    {
        LenaSoftwareDBEntities db = new LenaSoftwareDBEntities();
        /// <summary>
        /// --veritabanindaki verilerle eşleştirip ilk bulduğunu ya da varsayılanı getirir.
        /// --varsa true doner.
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public Users Login(string username, string password)
        {
            var giris = db.Users.Where(k => k.username == username && k.password == password).FirstOrDefault();

            return giris;
        }
    }
}
