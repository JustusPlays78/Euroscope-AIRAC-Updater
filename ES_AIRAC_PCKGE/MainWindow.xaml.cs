using System.Windows;


namespace ES_AIRAC_PCKGE;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        Utils.Logger.CreateLogFile(config.Config.GetStandartConfig());

        InitializeComponent();
        

    }
}