using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cloudforce_Revamped_V3
{
    internal class GamesJSON
    {

        public static string getgamejson()
        {
            WebClient web = new WebClient();
            return web.DownloadString("https://raw.githubusercontent.com/zortos293/Cloudforce-Revamped-Resources/Dev/Games.json");
        }
        public static GamesJSON.Root GameJSON = JsonConvert.DeserializeObject<GamesJSON.Root>(getgamejson());
        
        public class Game
        {
            public string GameName { get; set; }
            public string GameImage { get; set; }
            public string GameIcon { get; set; }
            public string GameDescription { get; set; }
            public string GameSize { get; set; }
            public string GameDownloadCloudURL { get; set; }
            public string GameDownloadURL { get; set; }
            public string GameExe { get; set; }
            public string GameArguments { get; set; }
            public string GameUpdateLog { get; set; }
            public bool GamePaid { get; set; }
        }

        public class Root
        {
            public List<Game> Games { get; set; }
        }




    }
}
