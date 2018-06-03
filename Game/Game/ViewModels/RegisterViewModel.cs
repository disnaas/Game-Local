﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.MVVM.Commands;
using ToolBoxSupp.Mediator;

namespace Game.ViewModels
{
    public class RegisterViewModel : NavigationPage
    {
        private string _Pseudo;

        public string Pseudo
        {
            get { return _Pseudo; }
            set { _Pseudo = value; RaisePropertyChanged(); }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(); }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; RaisePropertyChanged(); }
        }
        private ICommand _SubmitRegister;
        public ICommand SubmitRegister
        {
            get { return _SubmitRegister ?? (_SubmitRegister = new RelayCommand(SubmitRegisterExec,SubmitRegisterCanExec)); }
        }

        private bool SubmitRegisterCanExec()
        {
            if (!string.IsNullOrWhiteSpace(Pseudo) && !string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SubmitRegisterExec()
        {
            Mediator<NavigationPage>.Instance.Send(new HomeViewModel());
        }
    }
}
