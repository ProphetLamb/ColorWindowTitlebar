using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestApp
{
    class MainWindowViewModel : VMBase
    {
        private bool _colorWindowTitlebar = true;
        public bool ColorWindowTitlebar
        {
            get => _colorWindowTitlebar;
            set => Set(ref _colorWindowTitlebar, value);
        }
    }
}
