using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFCanExcute.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string MyEntry { get; set; }

        public void OnMyEntryChanged()
        {
            LoginCommand.RaiseCanExecuteChanged();
        }
        public DelegateCommand LoginCommand { get; set; }

        public MainPageViewModel()
        {
            LoginCommand = new DelegateCommand(
            () =>
            {
                Title = MyEntry;
            },

            () =>
            {
                if(MyEntry != null && MyEntry.Length >6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
