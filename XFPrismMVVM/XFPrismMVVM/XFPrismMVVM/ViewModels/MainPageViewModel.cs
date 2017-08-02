using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFPrismMVVM.ViewModels
{
    public class MainPageViewModel :INotifyPropertyChanged , INavigationAware
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string MyEntry { get; set; }
        public string Title { get; set; }
        public string MyLabel { get; set; }
        public DelegateCommand OKCommand { get; set; }

        public MainPageViewModel()
        {
            OKCommand = new DelegateCommand(()=> 
            {
                MyLabel = MyEntry;
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
