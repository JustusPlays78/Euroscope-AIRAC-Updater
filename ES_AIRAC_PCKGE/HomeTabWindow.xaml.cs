using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ES_AIRAC_PCKGE.EnumsList;
using ES_AIRAC_PCKGE.Services;

namespace ES_AIRAC_PCKGE;



public partial class HomeTabWindow : Window
{
    
    LoggerService _loggerService = new LoggerService();
    ConfigService _configService = new ConfigService();
    
    private bool isEverythingAlreadyStarted = false;
    private bool isHomeTabOpen = true;
    private bool isCredentailsTabOpen = false;
    private bool isFeaturesTabOpen = false;
    private Brush bluecolor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#233244"));
    private Brush whitecolor = Brushes.White;
    
    public HomeTabWindow()
    {
            //LoggerStart
            _loggerService.OnStart(_configService);
            _loggerService.LogMessage(SeverityLevelType.Info, "LoggerService started");
        
        
            //Configgetter
            _loggerService.LogMessage(SeverityLevelType.Info, "Config setup started");
            _configService.OnStart();
            _loggerService.LogMessage(SeverityLevelType.Info, "Config setup completed");
            
            
            
        
        InitializeComponent();
        isHomeTabOpen = true;
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
                isHomeTabOpen = true;
                isCredentailsTabOpen = false;
                isFeaturesTabOpen = false;
            } 
            else if (sender.Equals(CredentialsTabButton))
            {
                EnableDisableTab(HomeTabGrid,HomeTabButton, false);
                EnableDisableTab(CredentialsTabGrid, CredentialsTabButton, true);
                EnableDisableTab(FeaturesTabGrid, FeaturesTabButton, false);
                isHomeTabOpen = false;
                isCredentailsTabOpen = true;
                isFeaturesTabOpen = false;
            }
            else if (sender.Equals(FeaturesTabButton))
            {
                EnableDisableTab(HomeTabGrid,HomeTabButton, false);
                EnableDisableTab(CredentialsTabGrid, CredentialsTabButton, false);
                EnableDisableTab(FeaturesTabGrid, FeaturesTabButton, true);
                isHomeTabOpen = false;
                isCredentailsTabOpen = false;
                isFeaturesTabOpen = true;
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