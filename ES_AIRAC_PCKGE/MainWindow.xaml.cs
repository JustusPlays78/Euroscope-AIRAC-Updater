using System.Windows;
using ES_AIRAC_PCKGE.Utils;
using utillogger = ES_AIRAC_PCKGE.Utils.Logger;
using configon = ES_AIRAC_PCKGE.config.Config;


namespace ES_AIRAC_PCKGE;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        //LoggerStart
        utillogger.LoggerStart();
        utillogger.LogMessage(SeverityLevel.Info, "Logger started");
        
        
        //Configgetter
        utillogger.LogMessage(SeverityLevel.Info, "Config setup started");
        configon.onConfigStart();
        utillogger.LogMessage(SeverityLevel.Info, "Config setup completed");
        
        
        InitializeComponent();
        

    }
}