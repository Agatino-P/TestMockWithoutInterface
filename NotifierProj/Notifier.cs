using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotifierProj
{
    public class Notifier
    {
        private Action<IEnumerable<string>> _notifyAction;

        public Notifier( Action<IEnumerable<string>> notifyAction)
        {
            _notifyAction = notifyAction;
        }

        public void DoNotify(IEnumerable<string> news)
        {
            _notifyAction?.Invoke(news);
        }
    }
}
