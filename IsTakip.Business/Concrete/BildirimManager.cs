using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
