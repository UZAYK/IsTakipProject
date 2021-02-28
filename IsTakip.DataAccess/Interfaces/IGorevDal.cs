using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.DataAccess.Interfaces
{

    public interface IGorevDal : IGenericDal<Gorev>
    {
        List<Gorev> GetirIdAciliyetTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        Gorev GetirAciliyetileId(int id);
        List<Gorev> GetirAppUserId(int appUserId);
        Gorev GetirRaporlarileId(int id);

    }
}
