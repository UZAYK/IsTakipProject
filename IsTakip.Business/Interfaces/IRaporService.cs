using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.Interfaces
{
   public interface IRaporService : IGenericService<Rapor>
    {
        Rapor GetirGorevileId(int id);
    }
}
