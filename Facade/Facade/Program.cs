using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void notification_notificationevent(object sender, EventArgs e)
        {
            Notification n = (Notification)sender;
            Console.WriteLine(n.ToString());
        }
        static void drive_driveevent(object sender, EventArgs e)
        {
            Drive d = (Drive)sender;
            Console.WriteLine(d.ToString());
        }
        private static void power_powerevent(object sender, EventArgs e)
        {
            Power p = (Power)sender;
            Console.WriteLine(p.ToString());
        }
        static void Main(string[] args)
        {
            var drive = new Drive();
            var power = new Power();
            var notification = new Notification();
            var microwave = new Microwave(drive, power, notification);
            power.powerevent += power_powerevent;
            drive.driveevent += drive_driveevent;
            notification.notificationevent += notification_notificationevent;
            Console.WriteLine("Разморозка");
            microwave.Defrost();
        }
    }
}
