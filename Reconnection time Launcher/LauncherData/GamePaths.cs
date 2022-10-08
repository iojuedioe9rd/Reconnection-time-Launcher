using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconnection_time_Launcher.LauncherData
{
    public class GamePaths
    {
        public string ExeFile = string.Empty;
        public string GamesDir = string.Empty;
        public string GameVerFile = string.Empty;

        public GamePaths(string Version)
        {
            GamesDir = Path.Combine(Environment.CurrentDirectory, "Vesions");
            GameVerFile = Path.Combine(GamesDir, $"ver{Version}");
            ExeFile = Path.Combine(GameVerFile, $"Build({Version})", "Reconnection time.exe");
        }
    }
}
