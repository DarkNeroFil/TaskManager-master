using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.ViewModels;

namespace ToDoList.Models
{
   public class Task : BaseViewModel
    {
        private int id;
        private string name;
        private string description;
        private string dateStart;
        private string dateEnd;
        
        private bool complete;

        public int Id { get { return id; } set
            {
                id = value;
                NotifyPropertyChanged(nameof(Id));
            }
        }
        public string Name { get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }
        public string Description { get { return description; } 
            set
            {   
                description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }
        public string DateStart
        {
            get { return dateStart; }
            set
            {
                dateStart = value;
                NotifyPropertyChanged(nameof(DateStart));
            }
        }
        public string DateEnd
        {
            get { return dateEnd; }
            set
            {
                dateEnd = value;
                NotifyPropertyChanged(nameof(DateEnd));
            }
        }
        public bool Complete
        {
            get { return complete; }
            set
            {
                complete = value;
                NotifyPropertyChanged(nameof(Complete));
            }
        }
    }
}
