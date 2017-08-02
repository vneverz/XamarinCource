﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XFCommand.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {


        public event PropertyChangedEventHandler PropertyChanged;


        public string Title { get; set; }

        public DelegateCommand<String> ButtonCommand { get; set; }



        public MainPageViewModel()
        {
            ButtonCommand = new DelegateCommand<string>(x =>
            {
                Title = $"You have realy submit{x}";
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
