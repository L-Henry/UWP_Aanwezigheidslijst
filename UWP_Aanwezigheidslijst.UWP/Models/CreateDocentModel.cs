using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_Aanwezigheidslijst.BusinessLogic;
using UWP_Aanwezigheidslijst.BusinessLogic.Contracts;

namespace UWP_Aanwezigheidslijst.UWP.Models
{
    public class CreateDocentModel
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly CreateDocent Docent = new CreateDocent();

        public void CreateDocent()
        {
            _docentService.Create(Docent);
        }
    }
}
