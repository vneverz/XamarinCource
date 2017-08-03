using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFSimpleNavi.ViewModels
{
    public class NextPageViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand goBackCommand { get; set; }

        private readonly INavigationService _navigationService;
        public NextPageViewModel(INavigationService navigationService)
        {
            //xfn tab*2
            _navigationService = navigationService;
            //limda委派方法
            goBackCommand = new DelegateCommand(()=> {
                //沒有傳回値用此方法
                _navigationService.GoBackAsync();
            });
        }
    }
}
