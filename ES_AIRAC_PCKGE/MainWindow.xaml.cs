using System.Windows;
using ES_AIRAC_PCKGE.Utils;
using utillogger = ES_AIRAC_PCKGE.Utils.Logger;


namespace ES_AIRAC_PCKGE;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        utillogger.LoggerStart();
        utillogger.LogMessage(SeverityLevel.Info, "Application started");
        
        
        InitializeComponent();
        

    }
}