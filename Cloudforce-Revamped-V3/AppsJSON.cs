using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudforce_Revamped_V3
{
    internal class AppsJSON
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class App
        {
            public string AppName { get; set; }
            public string AppImage { get; set; }
            public string AppDescription { get; set; }
            public string AppGFNIssues { get; set; }
            public string AppGFNStatus { get; set; }
            public string AppDownloadUrl { get; set; }
            public string AppExe { get; set; }
            public string AppArguments { get; set; }
        }


        public class Root
        {
            public List<App> Apps { get; set; }
        }

    }
}
