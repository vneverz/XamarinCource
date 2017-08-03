using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFSimpleNavi.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }

        public DelegateCommand NextPageCommand { get; set; }
        //宣告欄位儲存會再用到的參數
        private readonly INavigationService _navigationService; 
        //建構式注入法
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService; 
            NextPageCommand = new DelegateCommand(async( )=>
            {
                //不是下一頁就是上一頁
                await _navigationService.NavigateAsync("NextPage");
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
