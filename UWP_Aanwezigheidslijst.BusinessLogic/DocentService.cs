using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UWP_Aanwezigheidslijst.BusinessLogic.Contracts;
using UWP_Aanwezigheidslijst.EF;
using UWP_Aanwezigheidslijst.EF.Model;

namespace UWP_Aanwezigheidslijst.BusinessLogic
{
    public class DocentService
    {

        public ObservableCollection<ViewDocent> GetDocenten()
        {
            ObservableCollection<ViewDocent> docenten = new ObservableCollection<ViewDocent>();
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                foreach (var item in ctx.Docenten)
                {
                    docenten.Add(new ViewDocent { Id = item.Id, Naam = item.Naam, Bedrijf = item.Bedrijf});
                }
            }
            return docenten;
        }



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
