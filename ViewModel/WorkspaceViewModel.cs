using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.ViewModel
{
    public abstract class WorkspaceViewModel:ViewModelBase
    {
        private readonly string path;

        public RelayCommand? CloseCommand { get; set; }
        public WorkspaceViewModel(string path):base()
        {
            this.path = path;
        }
        public void OnRequestClose()
        {
            RequestClose?.Invoke(null,null);
        }
        public event EventHandler? RequestClose;
    }
}
