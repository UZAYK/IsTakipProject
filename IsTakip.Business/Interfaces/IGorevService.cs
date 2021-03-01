using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IsTakip.Business.Interfaces
{
   public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetirIdAciliyetTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        Gorev GetirAciliyetileId(int id);
        List<Gorev> GetirAppUserId(int appUserId);
        Gorev GetirRaporlarileId(int id);
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter);


    }
}
