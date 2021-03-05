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
    public class EfRaporRepository : EfGenericRepository<Rapor>, IRaporDal
    {
        public Rapor GetirGorevileId(int id)
        {
            using var context = new IsTakipContext();
            return context.Raporlar.Include(I => I.Gorev).ThenInclude(I => I.Aciliyet).Where(I => I.Id == id).FirstOrDefault();
        }

        public int GetirRaporSayisi()
        {
            using var context = new IsTakipContext();
            return context.Raporlar.Count();
        }

        public int GetirRaporSayisiilAppUserId(int id)
        {
            using var context = new IsTakipContext();
            var result = context.Gorevler.Include(I => I.Raporlar).Where(I => I.AppUserId == id);

            return result.SelectMany(I => I.Raporlar).Count();
        }
    }
}
