using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Helpers
{
    public static class LaunchHelper
    {
        public static void Launch(string filePath)
        {
            ProcessStartInfo processStartInfo = new()
            {
                FileName = filePath,
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }
    }
}
