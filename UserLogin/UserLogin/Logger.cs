using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.Username + ";"
              + LoginValidation.currentUserRole + ";" + activity + "\n";

            currentSessionActivities.Add(activityLine);

            if (File.Exists("log.txt") == true)
            {
                File.AppendAllText("log.txt", activity);
            }
        }

        public static string GetCurrentSessionActivities()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string session in currentSessionActivities)
            {
                sb.Append(session);
            }
            string currentActivity = Convert.ToString(sb);
            return currentActivity;
        }

        public static IEnumerable<string> GetLogFile()
        {
            StreamReader streamReader = new StreamReader("log.txt");
            List<string> activities = new List<string>();
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                activities.Add(line);
            }

            streamReader.Close();
            return activities;
        }

        public static IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            return from activity in currentSessionActivities where activity.Contains(filter) select activity;
        }
    }
}
