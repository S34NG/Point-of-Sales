using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.ViewModel
{
    public class CustomerViewModel : WorkspaceViewModel
    {
        public CustomerViewModel(string path) : base(path)
        {
        }

        protected override void OnRequestClose()
        {
            throw new NotImplementedException();
        }
    }
}
