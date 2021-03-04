using IsTakip.DataAccess.Concrete.EntityFrameworkCore.Context;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace IsTakip.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBildirimRepository : EfGenericRepository<Bildirim>, IBildirimDal
    {
        public List<Bildirim> GetirOkunmayanlar(int appUserId)
        {
            using var context = new IsTakipContext();
            return context.Bildirimler.Where(I => I.AppUserId == AppUserId && !I.Durum).ToList();
        }
    }
}
