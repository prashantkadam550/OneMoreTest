using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    static class GitCommand
    {
        public static String Fetch
            (String repo,
            String userName,
            String password,
            String branchName
            )
        {
            return Url("fetch --prune", repo, branchName, userName, password);
        }

        public static String Pull
            (String repo,
            String userName,
            String password,
            String branchName
            )
        {
            return Url("pull --prune", repo, branchName, userName, password);
        }

        private static String Url(
            String action,
            String repository,
            String branchName,
            String userName,
            String password
            )
        {
            String credentials = String.Empty;
            if (String.IsNullOrEmpty(action) == false)
            {
                action = " " + action + " ";
                credentials = userName + ":" + WebUtility.UrlEncode(password) + "@";
            }

            // For commands that don't have a repository argument, we want to avoid appending the .git extension
            if (String.IsNullOrEmpty(repository) == false)
                repository += ".git ";


            String url = String.Format(
                @"{0}https://{3}github.com/{1}{2}",
                action, repository, branchName, credentials
                ).Trim();

            return url;
        }
    }
}
