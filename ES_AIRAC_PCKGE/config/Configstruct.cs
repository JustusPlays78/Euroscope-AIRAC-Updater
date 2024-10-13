namespace ES_AIRAC_PCKGE.config;

public struct Configstruct
{
    public String Version { get; set; }
    public String AppPath { get; set; }
    public String ConfigPath { get; set; }
    public String LogPath { get; set; }
    public List<String> FeaturesList { get; set; }
}