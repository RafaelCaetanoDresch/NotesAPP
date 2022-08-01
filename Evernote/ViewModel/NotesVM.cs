﻿using Evernote.Model;
using Evernote.ViewModel.Commands;
using System.Collections.ObjectModel;

namespace Evernote.ViewModel;

public class NotesVM
{
    public ObservableCollection<Notebook> Notebooks { get; set; }

    private Notebook selectedNotebook;
    public Notebook SelectedNotebook
    {
        get { return selectedNotebook; }
        set
        { 
            selectedNotebook = value;
            //TODO: get notes
        }
    }

    public ObservableCollection<Note> Notes { get; set; }
    public NewNotebookCommand NewNotebookCommand { get; set; }
    public NewNoteCommand NewNoteCommand { get; set; }

    public NotesVM()
    {
        NewNotebookCommand = new NewNotebookCommand(this);
        NewNoteCommand = new NewNoteCommand(this);
    }
}