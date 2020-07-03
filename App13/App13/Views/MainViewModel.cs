using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace App13.Views
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Command PositionCommand { protected set; get; }
        ObservableCollection<View> _views;
        public ObservableCollection<View> Views
        {
            set
            {
                _views = value;
                OnPropertyChanged("Views");
            }
            get
            {
                return _views;
            }
        }
        public MainViewModel()
        {
            Views = new ObservableCollection<View>()
            {
                new  Image() { Source = "https://i.imgur.com/byOU8aY.jpg", Aspect = Aspect.AspectFill },
                new  Image() { Source = "https://i.imgur.com/xbDAyck.jpg", Aspect = Aspect.AspectFill },
                new  Image() { Source = "https://i.imgur.com/U6sO71h.jpg", Aspect = Aspect.AspectFill },
                new  Image() { Source = "https://i.imgur.com/OtOM95I.jpg", Aspect = Aspect.AspectFill },
                new  Image() { Source = "https://i.imgur.com/nfWP9M3.jpg", Aspect = Aspect.AspectFill }
            };
            PositionCommand = new Command(() =>
            {
                Debug.WriteLine("Posição selecionada.");
            });
        }
    }
}
