using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.ComponentModel;

namespace XFNaviPara.ViewModels
{
    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;   
        public string YourName { get; set; }
        public string YourEmail { get; set; }
        public string PassWord { get; set; }
        public NextPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("ID"))
            {
                //轉parameters物件型別
                var fooID = parameters["ID"] as MyData;
                YourEmail = fooID.YourEmail;
                YourName = fooID.YourName;

            }

            if (parameters.ContainsKey("PassWord"))
            {
                var fooPassWord = parameters["PassWord"] as string;
                PassWord = fooPassWord;
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
