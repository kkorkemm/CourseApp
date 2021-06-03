using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CourseApp.MVVMCore
{
    class INotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
