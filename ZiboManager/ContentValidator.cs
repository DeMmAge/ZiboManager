using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiboManager.Properties;

namespace ZiboManager
{
    public class ContentValidator
    {
        public static bool ValidateAircraft(string path)
        {
            // TODO: more checks
            bool aircraftFile = false;
            bool versionFile = false;

            if (File.Exists(path + "version.txt"))
            {
                versionFile = true;
            }

            if (File.Exists(path + "b738.acf"))
            {
                aircraftFile = true;
            }

            return aircraftFile && versionFile;
        }

    }
}
