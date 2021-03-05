using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System.Collections.Generic;

namespace IsTakip.Business.Concrete
{
    public class BildirimManager : IBildirimService
    {
        private readonly IBildirimDal _bildirimDal; 
        public BildirimManager(IBildirimDal bildirimDal)
        {
            _bildirimDal = bildirimDal;
        }

        public List<Bildirim> GetirHepsi()
        {
            return _bildirimDal.GetirHepsi();
        }

        public Bildirim GetirIdile(int id)
        {
            return _bildirimDal.GetirIdile(id);
        }

        public List<Bildirim> GetirOkunmayanlar(int appUserId)
        {
            return _bildirimDal.GetirOkunmayanlar(appUserId);
        }

        public int GetirOkunmayanSayisiileAppUserId(int appUserId)
        {
            return _bildirimDal.GetirOkunmayanSayisiileAppUserId(appUserId);
        }

        public void Guncelle(Bildirim tablo)
        {
            _bildirimDal.Guncelle(tablo);
        }

        public void Kaydet(Bildirim tablo)
        {
            _bildirimDal.Kaydet(tablo);
        }

        public void Sil(Bildirim tablo)
        {
            _bildirimDal.Sil(tablo);
        }
    }
}
