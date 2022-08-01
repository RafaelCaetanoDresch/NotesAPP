﻿namespace Evernote.ViewModel.Commands;

public class RegisterCommand : ICommand
{
    public LoginVM VM { get; set; }
    public event EventHandler CanExecuteChanged;

    public RegisterCommand(LoginVM vm)
    {
        VM = vm;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        //TODO: Login functionality
    }
}
