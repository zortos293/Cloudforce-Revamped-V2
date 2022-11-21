using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace Cloudforce_Revamped_V3
{
    internal class AppsJSON
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public static string getAPPjson()
        {
            WebClient web = new WebClient();
            return web.DownloadString("https://raw.githubusercontent.com/zortos293/Cloudforce-Revamped-Resources/Dev/Apps.json");
        }

        public static Root APPJson = JsonConvert.DeserializeObject<AppsJSON.Root>(getAPPjson());

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
            public string AppUpdateLog { get; set; }
        }

        public class Root
        {
            public List<App> Apps { get; set; }
        }
    }
}