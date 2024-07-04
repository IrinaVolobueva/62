using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6._2
{
    class GreenhouseFacade
    {
        private AutoWatering autoWatering;
        private LightingControl lightingControl;
        private TemperatureControl temperatureControl;
        private OwnerNotification ownerNotification;

        public GreenhouseFacade()
        {
            autoWatering = new AutoWatering();
            lightingControl = new LightingControl();
            temperatureControl = new TemperatureControl();
            ownerNotification = new OwnerNotification();
        }

        public void StartGreenhouse()
        {
            autoWatering.Start();
            lightingControl.Start();
            temperatureControl.Start();
            ownerNotification.Start();
        }

        public void StopGreenhouse()
        {
            autoWatering.Stop();
            lightingControl.Stop();
            temperatureControl.Stop();
            ownerNotification.Stop();
        }

        public void CheckSystems()
        {
            if (!autoWatering.IsWorking() || !lightingControl.IsWorking() || !temperatureControl.IsWorking() || !ownerNotification.IsWorking())
            {
                // Ожидание нажатия кнопки
                StartGreenhouse();
            }
        }
    }
}
