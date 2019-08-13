using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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


        public void Update(ViewDocent docent)
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                Docent updDocent = ctx.Docenten.SingleOrDefault(d => d.Id == docent.Id);
                updDocent.Naam = docent.Naam;
                updDocent.Bedrijf = docent.Bedrijf;

                ctx.SaveChanges();
            }
        }

        public void Delete(ViewDocent docent)
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                Docent delDocent = ctx.Docenten.SingleOrDefault(d => d.Id == docent.Id);
                ctx.Docenten.Remove(delDocent);

                ctx.SaveChanges();
            }
        }
    }
}
