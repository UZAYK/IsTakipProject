using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.DataAccess.Interfaces
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> GetirAdminOlmayanlar();
        List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);
    }
}
