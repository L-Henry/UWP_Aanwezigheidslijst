using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UWP_Aanwezigheidslijst.EF;

namespace UWP_Aanwezigheidslijst.BusinessLogic
{
    public static class ApplicationBootstrap
    {
        public static void Initialize()
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                ctx.Database.Migrate();
            }
        }
    }
}
