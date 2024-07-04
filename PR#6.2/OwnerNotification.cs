using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6._2
{
    class OwnerNotification : IGreenhouseSystem
    {
        private bool _isWorking;

        public void Start()
        {
            Console.WriteLine("Оповещение владельца включено.");
            _isWorking = true;
        }

        public void Stop()
        {
            Console.WriteLine("Оповещение владельца выключено.");
            _isWorking = false;
        }

        public bool IsWorking()
        {
            return _isWorking;
        }
    }

}
