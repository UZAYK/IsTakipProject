using IsTakip.Entities.Concrete;
using System.Collections.Generic;

namespace IsTakip.DataAccess.Interfaces
{
    public interface IAppUserDal
    {
        List<AppUser> GetirAdminOlmayanlar();

        List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);

        List<DualHalper> GetirEnCokGorevTamamlamisPersoneller();

        List<DualHalper> GetirEnCokGorevdeCalisanPersoneller();
    }
}
