using System.Net;

namespace RobloxUsernameChecker
{

    class Version
    {
        private static string Link = "https://github.com/PY44N/RobloxUsernameChecker/raw/master/Version.txt";

        public static string Check(bool online)
        {
            if (online == true)
            {
                using (var client = new WebClient())
                {
                    return client.DownloadString(Link);
                }
            }
            else
            {
                return "1";
            }
        }
    }
}
