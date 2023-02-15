using AvaloniaApplication1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ObservableCollection<Device> Devices  { get; set; }

        public MainWindowViewModel()
        {
            Devices = new() { new() { Id = 1, Name = "device1" }, new() { Id = 2, Name = "device2" } };
        }
    }
}
