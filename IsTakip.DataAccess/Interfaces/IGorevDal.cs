using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IsTakip.DataAccess.Interfaces
{

    public interface IGorevDal : IGenericDal<Gorev>
    {
        List<Gorev> GetirIdAciliyetTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev,bool>>filter);
        List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId,int aktifSayfa);
        Gorev GetirAciliyetileId(int id);
        List<Gorev> GetirAppUserId(int appUserId);
        Gorev GetirRaporlarileId(int id);

    }
}
