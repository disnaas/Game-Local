﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNET.MVVM.Command;
using ToolBoxNET.Pattern.Mediator;

namespace Game.ViewModels
{
    public class HomeViewModel : NavigationPage
    {
        // Binding bouton Connection
        private ICommand _ConnectBtn;
        public ICommand ConnectBtn
        {
            get { return _ConnectBtn ?? (_ConnectBtn = new RelayCommand(ConnectExec)); }
        }

        private void ConnectExec()
        {
            Mediator<NavigationPage>.Instance.Send(new ConnectViewModel());
        }
        private ICommand _RegisterBtn;
        public ICommand RegisterBtn
        {
            get { return _RegisterBtn ?? (_RegisterBtn = new RelayCommand(RegisterExec)); }
        }

        private void RegisterExec()
        {
            Mediator<NavigationPage>.Instance.Send(new RegisterViewModel());
        }
    }
}
