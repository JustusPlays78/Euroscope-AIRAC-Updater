using System.IO;
using System.Text;
using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services.Backend;

partial class BackendFileChangerService
{

    private ConfigService _configService = null;

    public Task RemoveFromFileChanger(ConfigService configService, int i)
    {
        _configService = configService;
        return Task.CompletedTask;
    }

    public Task ChangeInFileChanger(ConfigService configService, int i)
    {
        _configService = configService;

        List<string> LineListString = new List<string>();

        bool SpecialCanGo = false;
        
        string FileRead = File.ReadAllText(configService.GetFeatureListFileName()[i]);

        LineListString.AddRange(File.ReadAllLines(configService.GetFeatureListFileName()[i]));
        if (configService.GetFeatureListSpecialFeatureList() == null)
        {
            foreach (var line in LineListString)
            {

                if (line.Contains(configService.GetFeatureListOld()[i]))
                {
                    line.Replace(configService.GetFeatureListOld()[i], configService.GetFeatureListNew()[i]);
                }

            }
        }
        else
        {
            if (configService.GetFeatureListSpecialTypes()[i] == FeatureListSpecialType.after)
            {
                SpecialCanGo = false;
                foreach (var line in LineListString)
                {
                    if (line.Contains(configService.GetFeatureListSpecialFeatureList()[i]))
                    {
                        SpecialCanGo = true;
                    }
                    if (line.Contains(configService.GetFeatureListOld()[i]) && SpecialCanGo)
                    {
                        line.Replace(configService.GetFeatureListOld()[i], configService.GetFeatureListNew()[i]);
                    }

                }
            }else if (configService.GetFeatureListSpecialTypes()[i] == FeatureListSpecialType.before)
            {
                
            }
        }

        return Task.CompletedTask;
    }

    public Task AddFileChanger(ConfigService configService, int i)
    {
        _configService = configService;
        File.AppendAllText(configService.GetFeatureListFileName()[i], configService.GetFeatureListNew()[i]);
        return Task.CompletedTask;
    }

    public Task RemoveFileChanger(ConfigService configService, int i)
    {
        _configService = configService;
        File.Delete(configService.GetFeatureListFileName()[i]);
        return Task.CompletedTask;
    }
    
}