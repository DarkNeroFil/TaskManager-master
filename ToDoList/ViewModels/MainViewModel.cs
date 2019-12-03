using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ToDoList.Helpers;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Task> Tasks { get; set; }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??= new RelayCommand(obj =>
                {
                    Task task = new Task()
                    {
                        Name = "Новая задача",
                        Description = "Выполнить",
                        DateStart = DateTime.Now.ToShortDateString(),
                        DateEnd = DateTime.Now.ToShortDateString(),
                        Complete = true
                    };



                    Tasks.Insert(0, task);
                    selectedTask = task;

                  

                });
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                       (removeCommand = new RelayCommand(obj =>
                           {
                               Task task = obj as Task;
                               if (task != null)
                               {
                                   Tasks.Remove(task);
                                   
                               }
                           },
                           (obj) => Tasks.Count > 0));
            }
        }
        public MainViewModel()
        {
            Tasks = new ObservableCollection<Task>
            {
                new  Task {Id = 0, Name = "Молоко",
                           Description = "Сходить, купить молочка",
                           DateStart = DateTime.Now.ToShortDateString(),
                           DateEnd = DateTime.Now.ToShortDateString(),
                           Complete = true}
            };
        }

       

        private Task selectedTask;

        public Task SelectedTask
        {
            get { return selectedTask; }
            set
            {
                if (value != selectedTask)
                {
                    selectedTask = value;
                    NotifyPropertyChanged("SelectedTask");
                    HasTaskSelected = (selectedTask != null);
                    
                }
            }
        }

        private bool hasTaskSelected;
        public bool HasTaskSelected
        {
            get { return hasTaskSelected; }
            set
            {
                if (value != hasTaskSelected)
                {
                    hasTaskSelected = value;
                    NotifyPropertyChanged("HasTaskSelected");
                }
            }
        }
    }
}
