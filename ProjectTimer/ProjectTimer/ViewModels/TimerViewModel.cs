using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System;

namespace ProjectTimer.ViewModels
{
    public class TimerViewModel:ViewModelBase
    {
        private string _duration;
        public string Duration {
            get { return _duration; }
            set { Set(nameof(Duration), ref _duration, value); }
        }
        public string ButtonText { get; set; }
        public List<string> ProjectNames { get; set; }

        // Commands
        public RelayCommand TimerCommand { get; private set; }

        public TimerViewModel()
        {
            TimerCommand = new RelayCommand(StartStopTimer);
            Duration = "00:00:00";
            ButtonText = "Start";
            ProjectNames = new List<string> { "Foo", "Bar", "Baz" };
        }

        private void StartStopTimer()
        {
            if (ButtonText == "Start")
            {
                ButtonText = "Stop";
                Duration = "00:33:44";
            }
            else
            {
                ButtonText = "Start";
            }
        }
    }
}
