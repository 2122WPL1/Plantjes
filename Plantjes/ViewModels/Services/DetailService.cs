using System.ComponentModel;
using Plantjes.Dao;
using Plantjes.ViewModels.Interfaces;

namespace Plantjes.ViewModels.Services;

public class DetailService : IDetailService, INotifyPropertyChanged {
    private static DetailService _detailService;
    //Robin
    //Op dit moment wordt de service niet gebruikt, deze is opgezet om later de plantdetails te kunnen weergeven en te kunnen toevoegen in alle usercontrols

    private DAOLogic _dao;
    private ISearchService _searchService = (ISearchService)App.Current.Services.GetService(typeof(ISearchService));

    public DetailService(ISearchService searchService) {
        _dao = DAOLogic.Instance();
        _searchService = searchService;
    }

    public event PropertyChangedEventHandler PropertyChanged;
}