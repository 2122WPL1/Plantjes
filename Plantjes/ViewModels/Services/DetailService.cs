using System.ComponentModel;
using Plantjes.Dao;

namespace Plantjes.ViewModels.Services;

public class DetailService : INotifyPropertyChanged {
    private static DetailService _detailService;
    //Robin
    //Op dit moment wordt de service niet gebruikt, deze is opgezet om later de plantdetails te kunnen weergeven en te kunnen toevoegen in alle usercontrols

    private DAOLogic _dao;
    private SearchService _searchService;

    public DetailService(SearchService searchService) {
        _dao = DAOLogic.Instance();
        _searchService = searchService;
    }

    public event PropertyChangedEventHandler PropertyChanged;
}