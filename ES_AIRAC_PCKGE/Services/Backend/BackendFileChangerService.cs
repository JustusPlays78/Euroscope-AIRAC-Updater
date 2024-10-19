using System.IO;

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
        
        //4File
        
        
        //Searchpattern
        
        //Specialfeature bevor und afterr
        
        
        
        
        
        
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