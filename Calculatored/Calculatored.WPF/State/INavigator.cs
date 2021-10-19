using Calculatored.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Calculatored.WPF.State
{
    public enum ViewType
    {
        Home,
        Login,
        Data
    }
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModel { get; }
    }
}
