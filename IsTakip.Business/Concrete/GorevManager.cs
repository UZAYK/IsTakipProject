using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IsTakip.Business.Concrete
{
    public class GorevManager : IGorevService
    {
        public readonly IGorevDal _gorevDal;
        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }

        public Gorev GetirAciliyetileId(int id)
        {
            return _gorevDal.GetirAciliyetileId(id);
        }

        public List<Gorev> GetirAppUserId(int appUserId)
        {
            return _gorevDal.GetirAppUserId(appUserId);
        }

        public int GetirGorevSayisiTamamlananileAppUserId(int id)
        {
            return _gorevDal.GetirGorevSayisiTamamlananileAppUserId(id);
        }

        public int GetirGorevSayisiTamamlanmasiGerekenAppUserId(int id)
        {
            return _gorevDal.GetirGorevSayisiTamamlanmasiGerekenAppUserId(id);
        }

        public List<Gorev> GetirHepsi()
        {
            return _gorevDal.GetirHepsi();
        }

        public List<Gorev> GetirIdAciliyetTamamlanmayan()
        {
            return _gorevDal.GetirIdAciliyetTamamlanmayan();
        }

        public Gorev GetirIdile(int id)
        {
            return _gorevDal.GetirIdile(id);
        }

        public Gorev GetirRaporlarileId(int id)
        {
            return _gorevDal.GetirRaporlarileId(id);
        }

        public List<Gorev> GetirTumTablolarla()
        {
            return _gorevDal.GetirTumTablolarla();
        }

        public List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter)
        {
            return _gorevDal.GetirTumTablolarla(filter);
        }

        public List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId, int aktifSayfa)
        {
            return _gorevDal.GetirTumTablolarlaTamamlanmayan(out toplamSayfa, userId, aktifSayfa);
        }

        public void Guncelle(Gorev tablo)
        {
            _gorevDal.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            _gorevDal.Kaydet(tablo);
        }

        public void Sil(Gorev tablo)
        {
            _gorevDal.Sil(tablo);
        }
    }
}
