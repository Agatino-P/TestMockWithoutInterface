using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NotifierProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TestMockApp
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<string> _strings = new List<string>() { "a", "b" };
        private Notifier _notifier;
        
        public MainWindowViewModel()
        {
            _notifier = new Notifier(OnNotify);
        }

        private RelayCommand _callNotifierCmd;
        public RelayCommand CallNotifierCmd => _callNotifierCmd ?? (_callNotifierCmd = new RelayCommand(
            () => callNotifier(),
            () => { return 1 == 1; },
            keepTargetAlive: true
            ));
        private void callNotifier()
        {
            _notifier.DoNotify(_strings);
        }

        public void OnNotify(IEnumerable<string> news)
            {
            string message= string.Join(", ", news);
            MessageBox.Show(message);
            }


    }
}
