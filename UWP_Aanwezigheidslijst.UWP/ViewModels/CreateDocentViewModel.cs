using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UWP_Aanwezigheidslijst.UWP.Commands;
using UWP_Aanwezigheidslijst.UWP.Models;

namespace UWP_Aanwezigheidslijst.UWP.ViewModels
{
    public class CreateDocentViewModel : BaseViewModel<CreateDocentModel>
    {
        public readonly ICommand SaveCommand;



        public CreateDocentViewModel() : base(new CreateDocentModel())
        {
            SaveCommand = new RelayCommand(() => Save());
        }


        public void Save()
        {
            Model.CreateDocent();
        }

        public string Naam
        {
            get => Model.Docent.Naam;
            set => SetProperty(Model.Docent.Naam, value, ()=>Model.Docent.Naam = value);
        }
        public string Bedrijf
        {
            get => Model.Docent.Bedrijf;
            set => SetProperty(Model.Docent.Bedrijf, value, () => Model.Docent.Bedrijf = value);
        }
    }
}
