using System;
using UWP_Aanwezigheidslijst.BusinessLogic.Contracts;
using UWP_Aanwezigheidslijst.EF;
using UWP_Aanwezigheidslijst.EF.Model;

namespace UWP_Aanwezigheidslijst.BusinessLogic
{
    public class DocentService
    {
        public void Create(CreateDocent docent)
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                ctx.Add(new Docent()
                {
                    Bedrijf = docent.Bedrijf,
                    Naam = docent.Naam
                });

                ctx.SaveChanges();
            }
        }
    }
}
