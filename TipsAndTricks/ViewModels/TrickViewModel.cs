using System;
using System.ComponentModel;

namespace TipsAndTricks.ViewModels
{
    public class TrickViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public TrickViewModel()
        {
            Name = "Elliot";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
