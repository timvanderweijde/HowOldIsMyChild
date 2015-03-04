using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Popups;
using Caliburn.Micro;

namespace UniversalApp.ViewModels
{
    public class MainViewModel : Screen
    {
        public MainViewModel()
        {
            Childs = new BindableCollection<ChildViewModel>
            {
                new ChildViewModel("Daan van der Weijde", new DateTime(2011, 10, 30)),
                new ChildViewModel("Lukas van der Weijde", new DateTime(2014, 2, 25)),
            };
        }

        public BindableCollection<ChildViewModel> Childs
        {
            get;
            private set;
        }

        public async void ChildSelected(ChildViewModel child)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", child.Name), "Child Selected");

            await dialog.ShowAsync();
        }
    }
}
