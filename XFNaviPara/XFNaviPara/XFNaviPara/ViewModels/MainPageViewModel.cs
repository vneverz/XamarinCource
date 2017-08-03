using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFNaviPara.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string YourName { get; set; }
        public string YourEmail { get; set; }
        public string PassWord { get; set; }

        public DelegateCommand GoNextCommand { get; set; }

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService   )
        {

            _navigationService = navigationService;
            GoNextCommand = new DelegateCommand(()=>
            {
                //導航參數用物件
                var fooPara = new NavigationParameters();
                var fooMydata = new MyData();
                //fooMydata.YourName = this.YourName;
                //fooMydata.YourEmail = this.YourEmail;
                //fooPara.Add("ID", fooMydata);

                fooPara.Add("ID", new MyData
                {
                    YourEmail = YourEmail,
                    YourName = YourName
                });
                _navigationService.NavigateAsync(
                    $"NextPage?PassWord={PassWord}", fooPara);
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
