using KeyAuth;

namespace Cloudforce_Revamped_V3
{
    internal class LoginTools
    {
        public static api KeyAuthApp = new api(
            name: "CF Early",
            ownerid: "0t0Sr0pLaB",
            secret: "c52ed8ebcefc829ffed9a73e9c85b73fd5a8e244abec5531ef1cf87628d181e0",
            version: "1.0"
        );

        public static bool SubExist(string name)
        {
            if (KeyAuthApp.user_data.subscriptions == null)
                return false;
            if (KeyAuthApp.user_data.subscriptions.Exists(x => x.subscription == name))
                return true;
            return false;
        }
    }
}