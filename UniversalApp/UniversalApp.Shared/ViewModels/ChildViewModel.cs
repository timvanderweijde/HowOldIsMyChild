using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalApp.ViewModels
{
    public class ChildViewModel
    {
        public ChildViewModel(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name
        {
            get;
            private set;
        }

        public DateTime BirthDate
        {
            get;
            private set;
        }
    }
}
