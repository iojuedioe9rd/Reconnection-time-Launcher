using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconnection_time_Launcher.LauncherData
{
    public class VersionManger
    {
        public Dictionary<string, string> Ver;

        private MainWindow mainWindow;
        public VersionManger(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

    }
}
