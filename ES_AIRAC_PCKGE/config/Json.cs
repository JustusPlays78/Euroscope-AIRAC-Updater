using System.IO;
using System.Net;
using System.Text.Json;
using System.Windows.Documents;
using ES_AIRAC_PCKGE.Utils;
using utillogger = ES_AIRAC_PCKGE.Utils.Logger;

namespace ES_AIRAC_PCKGE.config;

public class Json
{

    public static Config GetConfig()
    {
        Config c = new Config();
        
        return c;
    }

    public static Boolean doesConfigJsonExist()
    {
        try
        {
            string json = File.ReadAllText("config.json");
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    

    public static void CreateStandardConfigJson(Config c)
    {
        utillogger.LogMessage(SeverityLevel.Info, "Creating new ConfigJson");
        string json = JsonSerializer.Serialize(c);
        utillogger.LogMessage(SeverityLevel.Info, json);
        //File.WriteAllText(c.ConfigPath, json);
    }
    
}