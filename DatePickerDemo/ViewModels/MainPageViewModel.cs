using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace DatePickerDemo.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private DateTime? _startDateTime;

        [ObservableProperty]
        private DateTime? _endDateTime;

        [ObservableProperty]
        private string? _caption;

        [RelayCommand]
        void CleanDate()
        {
            StartDateTime = DateTime.MinValue;
            EndDateTime = DateTime.MaxValue;
        }

        public MainPageViewModel()
        {
            Caption = "Custom DateTime Pickers";
            StartDateTime = DateTime.Now;
            EndDateTime = DateTime.Now.AddDays(3);
        }
    }

}
