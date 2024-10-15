using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ES_AIRAC_PCKGE.EnumsList;
using ES_AIRAC_PCKGE.Services;
using ES_AIRAC_PCKGE.Services.Backend;

namespace ES_AIRAC_PCKGE;



public partial class HomeTabWindow : Window
{
    
    private LoggerService _loggerService = new();
    private ConfigService _configService = new();
    private BackendService _backendService = new();
    
    
    private Brush bluecolor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#233244"));
    private Brush whitecolor = Brushes.White;
    
    public HomeTabWindow()
    {
        
        _configService.OnStart();
        _loggerService.OnStart(_configService);
        _loggerService.LogMessage(SeverityLevelType.Info, "LoggerService started");
        _loggerService.LogMessage(SeverityLevelType.Info, "Config setup completed");
        
        _backendService.OnStart(_configService);
        
        
        InitializeComponent();
        EnableDisableTab(HomeTabGrid,HomeTabButton, true);
        EnableDisableTab(CredentialsTabGrid,CredentialsTabButton, false);
        EnableDisableTab(FeaturesTabGrid, FeaturesTabButton, false);
        _loggerService.LogMessage(SeverityLevelType.Info, "HomeTab open");
    }
        private void CloseApplication(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void MinimizeApplication(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void MouseDragAndDrop(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void OnTabSwitch(object sender, RoutedEventArgs e)
        {
            if(sender.Equals(HomeTabButton))
            {
                EnableDisableTab(HomeTabGrid,HomeTabButton, true);
                EnableDisableTab(CredentialsTabGrid, CredentialsTabButton, false);
                EnableDisableTab(FeaturesTabGrid, FeaturesTabButton, false);
            } 
            else if (sender.Equals(CredentialsTabButton))
            {
                EnableDisableTab(HomeTabGrid,HomeTabButton, false);
                EnableDisableTab(CredentialsTabGrid, CredentialsTabButton, true);
                EnableDisableTab(FeaturesTabGrid, FeaturesTabButton, false);
            }
            else if (sender.Equals(FeaturesTabButton))
            {
                EnableDisableTab(HomeTabGrid,HomeTabButton, false);
                EnableDisableTab(CredentialsTabGrid, CredentialsTabButton, false);
                EnableDisableTab(FeaturesTabGrid, FeaturesTabButton, true);
            }
        }
        private void EnableDisableTab(Grid grid, Button button, bool enable)
        {
            if (enable)
            {
                grid.Visibility = Visibility.Visible;
                button.Background = whitecolor;
                button.Foreground = bluecolor;
                _loggerService.LogMessage(SeverityLevelType.Info, "Enabled " + grid.Name);
            }
            else
            {
                grid.Visibility = Visibility.Hidden;
                button.Background = bluecolor;
                button.Foreground = whitecolor;
                _loggerService.LogMessage(SeverityLevelType.Info, "Disabled " + grid.Name);
            }

        }
}