using System.IO;
using System.Net;
using System.Text.Json;
using ES_AIRAC_PCKGE.config;

namespace ES_AIRAC_PCKGE.Utils;

public class Logger
{
    public static void CreateLogFile(Config config)
    {
        string path = config.LogPath + "\\log_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt";
        string LogTopStart = GetLogFileString(config.Version);
        File.WriteAllText(path, LogTopStart);
    }


    private static String GetLogFileString(String version)
    {
        String Logstring = "";
        List<String> LogFileList = new List<String>();
        
        LogFileList.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + " || Log ES_AIRAC_PCKGE log.txt" + "\n");
        LogFileList.Add("Author: Julscha - Version" + version + "\n");

        for (int i = 0; i < LogFileList.Count; i++)
        {
            if (i.Equals(0))
            {
                Logstring = LogFileList[i];
                continue;
            } 
            Logstring = Logstring + LogFileList[i];
        }

        return Logstring;
    }
}