using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Context;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Include(I => I.AppUser).Where(I => I.Id ==  id).FirstOrDefault();
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
    }
}

