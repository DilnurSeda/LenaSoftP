using LenaSoftwareFMP.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftwareFMP.BLL
{
    public class FormManager
    {
        LenaSoftwareDBEntities db = new LenaSoftwareDBEntities();

        public List<forms> FormList()
        {
            return db.forms.ToList();
        }

        public string FormInsert(string name,string description,DateTime? createdAt,int? createdBy)
        {
            try
            {
                forms insert = new forms();
                insert.name = name;
                insert.description = description;
                insert.createdAt = createdAt;
                insert.createdBy = createdBy;

                db.forms.Add(insert);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return "Kayıt başarılı";
                }
                else
                {
                    return "Kayıt yapılamadı";
                }
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }
    }
}
