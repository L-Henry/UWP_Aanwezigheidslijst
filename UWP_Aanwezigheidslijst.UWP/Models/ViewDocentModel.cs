using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_Aanwezigheidslijst.BusinessLogic;
using UWP_Aanwezigheidslijst.BusinessLogic.Contracts;

namespace UWP_Aanwezigheidslijst.UWP.Models
{
    public class ViewDocentModel
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly ViewDocent Docent = new ViewDocent();
        //public ObservableCollection<ViewDocent> Docenten = new ObservableCollection<ViewDocent>();

        public ObservableCollection<ViewDocent> GetDocenten()
        {
            return _docentService.GetDocenten();
        }
    }
}