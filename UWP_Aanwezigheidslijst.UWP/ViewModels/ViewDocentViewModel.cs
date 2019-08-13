using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UWP_Aanwezigheidslijst.BusinessLogic.Contracts;
using UWP_Aanwezigheidslijst.UWP.Commands;
using UWP_Aanwezigheidslijst.UWP.Models;

namespace UWP_Aanwezigheidslijst.UWP.ViewModels
{
    public class ViewDocentViewModel : BaseViewModel<ViewDocentModel>
    {
        //public readonly ICommand CreateCommand;
        public readonly ICommand UpdateCommand;
        public readonly ICommand DeleteCommand;


        private ViewDocent _selectedDocent;
        public ViewDocent SelectedDocent
        {
            get => _selectedDocent;
            set => SetProperty(ref _selectedDocent, value);
        }
        private ObservableCollection<ViewDocent> _docenten;
        public ObservableCollection<ViewDocent> Docenten
        {
            get => _docenten;
            set => SetProperty(ref _docenten, value);
        }

        public ViewDocentViewModel() : base(new ViewDocentModel())
        {
            UpdateCommand = new RelayCommand(() => UpdateDocent());
            DeleteCommand = new RelayCommand(() => DeleteDocent());

            _docenten = new ObservableCollection<ViewDocent>();

            GetDocenten();
        }

        public void GetDocenten()
        {
            Docenten = Model.GetDocenten();
        }

        private void DeleteDocent()
        {
            
            Model.DeleteDocent(SelectedDocent);
            GetDocenten();
        }

        private void UpdateDocent()
        {
            Model.UpdateDocent(SelectedDocent);
            GetDocenten();
        }



        public int Id
        {
            get => Model.Docent.Id;
            set => SetProperty(Model.Docent.Id, value, () => Model.Docent.Id = value);
        }
        public string Naam
        {
            get => Model.Docent.Naam;
            set => SetProperty(Model.Docent.Naam, value, () => Model.Docent.Naam = value);
        }
        public string Bedrijf
        {
            get => Model.Docent.Bedrijf;
            set => SetProperty(Model.Docent.Bedrijf, value, () => Model.Docent.Bedrijf = value);
        }
    }
}
