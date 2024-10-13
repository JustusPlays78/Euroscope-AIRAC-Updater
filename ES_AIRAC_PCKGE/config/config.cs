namespace ES_AIRAC_PCKGE.config;

public class Config
{
    public String Version { get; set; }
    public String AppPath { get; set; }
    public String ConfigPath { get; set; }
    public String LogPath { get; set; }
    public List<String> FeaturesList { get; set; }
    
    public Config()
    {

    }

    private Config GetConfig()
    {
        return Json.GetConfig();
    }

    public static Config GetStandartConfig()
    {
        Config c = new Config();
        c.Version = "1.0.0.0";
        c.AppPath = "Z:\\PrivatGit\\ES_AIRAC_PCKGE\\debuging";
        c.ConfigPath = "Z:\\PrivatGit\\ES_AIRAC_PCKGE\\debuging\\config.json";
        c.LogPath = "Z:\\PrivatGit\\ES_AIRAC_PCKGE\\debuging";
        return c;
    }
    
}