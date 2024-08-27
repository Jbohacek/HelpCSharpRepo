using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace _8_Eventy
{
    public class NetworkDevice
    {
        public delegate void StatusChangedHandler(string deviceName, string newStatus);
        public event StatusChangedHandler StatusChanged;

        public string Name { get; set; }
        private string status;


        public void ChangeStatus(string newStatus)
        {
            this.status = newStatus;
            StartEvent(newStatus);
        }

        private void StartEvent(string newStatus)
        {
            if (StatusChanged != null)
            {
                StatusChanged(Name, newStatus);
            }
        }
    }

    public class NetworkMonitor
    {
        public ConsoleColor consoleColor { get; set; }  

        public void OnStatusChanged(string deviceName, string newStatus)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"Zařízení {deviceName} změnilo stav na: {newStatus}");
            Console.ResetColor();
        }
    }
}
