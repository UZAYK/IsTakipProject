using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.Interfaces
{
   public interface IAppUserService
    {
        List<AppUser> GetirAdminOlmayanlar();

        List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);

        List<DualHalper> GetirEnCokGorevTamamlamisPersoneller();

        List<DualHalper> GetirEnCokGorevdeCalisanPersoneller();
    }
}
