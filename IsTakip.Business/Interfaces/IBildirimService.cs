using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.Interfaces
{
    public interface IBildirimService : IGenericService<Bildirim>
    {
        List<Bildirim> GetirOkunmayanlar(int appUserId);

        int GetirOkunmayanSayisiileAppUserId(int appUserId);

    }
}
