using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6._2
{
    class AutoWatering : IGreenhouseSystem
    {
        private bool isWorking;

        public void Start()
        {
            isWorking = true;
        }

        public void Stop()
        {
            isWorking = false;
        }

        public bool IsWorking()
        {
            return isWorking;
        }
    }
}
