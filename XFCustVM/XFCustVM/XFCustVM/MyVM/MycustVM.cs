using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFCustVM.NewModel
{
    public class MycustVM : INotifyPropertyChanged
    {
        public public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; } = "Welcome";

        public MycustVM ()
        {
        
        }
    }
}
