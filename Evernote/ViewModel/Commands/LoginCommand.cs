﻿namespace Evernote.ViewModel.Commands;

public class LoginCommand : ICommand
{

    public LoginVM VM { get; set; }

    public event EventHandler CanExecuteChanged;

    public LoginCommand(LoginVM vm)
    {
        VM = vm;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        //TODO: login functionaluty
    }
}
