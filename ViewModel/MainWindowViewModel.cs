using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.ViewModel
{
    public class MainWindowViewModel:WorkspaceViewModel
    {
        ObservableCollection<WorkspaceViewModel>? _workspaces = null;

        public MainWindowViewModel(string path) : base(path)
        {
            CloseCommand = new RelayCommand((o) => { OnRequestClose(); });
        }

        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if (_workspaces == null)
                {
                    _workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _workspaces.CollectionChanged += OnWorkspacesChanged;
                }
                return _workspaces;
            }
        }
        void OnWorkspacesChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += OnWorkspaceRequestClose;
            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= OnWorkspaceRequestClose;
        }
        void OnWorkspaceRequestClose(object? sender, EventArgs e)
        {
            var wsvm = sender as WorkspaceViewModel;
            if (sender != null && wsvm!=null) Workspaces.Remove(wsvm);
        }
    }
}
