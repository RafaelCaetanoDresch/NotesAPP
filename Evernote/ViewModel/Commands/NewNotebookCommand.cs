﻿namespace Evernote.ViewModel.Commands;

public class NewNotebookCommand : ICommand
{
    public NotesVM VM { get; set; }

    public event EventHandler CanExecuteChanged;

    public NewNotebookCommand(NotesVM vm)
    {
        VM = vm;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        //TODO Create a new Notebook
        VM.CreateNotebook();
    }
}
