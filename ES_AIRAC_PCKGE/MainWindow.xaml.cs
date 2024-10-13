using System.Windows;
using System.Windows.Input;
using ES_AIRAC_PCKGE.Utils;
using Microsoft.VisualBasic;
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
            Environment.Exit(0);
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
        private void HomeTabClose(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void HomeTabMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void HomeTab_Click(object sender, RoutedEventArgs e)
        {
        }

        private void FolderSelectButton_Click(object sender, RoutedEventArgs e)
        {
            /*FolderBrowserDialog fileddialog = new FolderBrowserDialog();
            if (fileddialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PathTextBox.Text = fileddialog.SelectedPath;
                Strings.IsSctPathSet = true;
                configon.SetSctPath(fileddialog.SelectedPath);
                ProcessStartButton.IsEnabled = true;
            }*/
        }
        private void JsonFileSelectButton_Click(object sender, RoutedEventArgs e)
        {
        }

        

        private void OnContentRendered(object sender, EventArgs e)
        {
        }

        private void CredentialsTab_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveCredsButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ProcessStart(object sender, RoutedEventArgs e)
        {

        }
        private void MouseDragAndDrop(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
}