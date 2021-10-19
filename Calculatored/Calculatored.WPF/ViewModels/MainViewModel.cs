using Calculatored.WPF.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatored.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
