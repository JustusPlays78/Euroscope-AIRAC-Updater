using System.Windows;
using System.Windows.Input;
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
        
        string builder = "Debug. WIP";
        DebugBox.Text = builder;
        DebugBox.Visibility = Visibility.Visible;

    }
    
    /*Opens the Folderdialog and sets the folderpath to the global value*/
        private void folderButton(object sender, RoutedEventArgs e)
        {

        }

        //ExitButton, was soll ich sagen
        private void ExitButton(object sender, RoutedEventArgs e)
        {

        }

        /*Starts the Credentials Saving Process*/
        private void SaveCredsButton(object sender, RoutedEventArgs e)
        {

        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void EdggButtonProcessStart_Click(object sender, RoutedEventArgs e)
        {

        }
}