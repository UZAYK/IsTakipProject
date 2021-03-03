using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Context;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IsTakip.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        public Gorev GetirAciliyetileId(int id)
        {
            using var context = new IsTakipContext();
            return context.Gorevler.Include(I => I.Aciliyet).FirstOrDefault(I => !I.Durum && I.Id == id);
        }

        public Gorev GetirRaporlarileId(int id)
        {
            using var context = new IsTakipContext();
            return context.Gorevler.Include(I => I.Raporlar).
                Include(I => I.AppUser).Where(I => I.Id == id).FirstOrDefault();
        }

        public List<Gorev> GetirAppUserId(int appUserId)
        {
            using var context = new IsTakipContext();
            return context.Gorevler.Where(I => I.AppUserId == appUserId).ToList();
        }

        public List<Gorev> GetirIdAciliyetTamamlanmayan()
        {
            using var context = new IsTakipContext();
            return context.Gorevler.Include(I => I.Aciliyet).Where(I => !I.Durum)
                 .OrderByDescending(I => I.OlusturulmaTarihi).ToList();
        }

        public List<Gorev> GetirTumTablolarla()
        {
            using var context = new IsTakipContext();
            return context.Gorevler.Include(I => I.Aciliyet).Include(I => I.Raporlar).Include(I => I.AppUser)
                .Where(I => !I.Durum).OrderByDescending(I => I.OlusturulmaTarihi).ToList();
        }

        public List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter)
        {
            using var context = new IsTakipContext();
            return context.Gorevler.Include(I => I.Aciliyet).Include(I => I.Raporlar).Include(I => I.AppUser)
                .Where(filter).OrderByDescending(I => I.OlusturulmaTarihi).ToList();
        }

        public List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId, int aktifSayfa = 1)
        {
            using var context = new IsTakipContext();
            var returnValue = context.Gorevler.Include(I => I.Aciliyet).Include(I => I.Raporlar).Include(I => I.AppUser)
                 .Where(I => I.AppUserId == userId && I.Durum).OrderByDescending(I => I.OlusturulmaTarihi);

            toplamSayfa =(int) Math.Ceiling((double)returnValue.Count() / 3);

            return returnValue.Skip((aktifSayfa - 1) * 3).Take(3).ToList();
        }
    }
}

