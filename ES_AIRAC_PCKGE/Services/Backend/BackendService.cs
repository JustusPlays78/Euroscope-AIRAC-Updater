using System.Windows.Input;
using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services.Backend;

public class BackendService
{
    LoggerService _loggerService = new();
    ConfigService _configService = new();




    public async void OnStart(ConfigService _configService)
    {
        _loggerService.LogMessage(SeverityLevelType.Info, "Backend Service Started");
    }
}