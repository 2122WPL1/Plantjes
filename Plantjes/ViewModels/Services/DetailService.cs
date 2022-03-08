using System.ComponentModel;
using GalaSoft.MvvmLight.Ioc;
using Plantjes.Dao;
using Plantjes.ViewModels.Interfaces;

namespace Plantjes.ViewModels.Services; 

public class DetailService : IDetailService, INotifyPropertyChanged {
    private static DetailService _detailService;

    private static readonly SimpleIoc iocc = SimpleIoc.Default;
    //Robin
    //Op dit moment wordt de service niet gebruikt, deze is opgezet om later de plantdetails te kunnen weergeven en te kunnen toevoegen in alle usercontrols

    private DAOLogic _dao;
    private ISearchService _searchService = iocc.GetInstance<ISearchService>();

    public DetailService(ISearchService searchService) {
        _dao = DAOLogic.Instance();
        _searchService = searchService;
    }

    public event PropertyChangedEventHandler PropertyChanged;
}