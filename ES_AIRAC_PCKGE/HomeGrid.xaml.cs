using System.Windows;
using System.Windows.Controls;

namespace ES_AIRAC_PCKGE
{
    public partial class HomeGrid : UserControl
    {
        public HomeGrid()
        {
            InitializeComponents();
            //InitializeEventHandlers();
        }

        private void InitializeComponents()
        {
            // This method is typically auto-generated by the XAML compiler
            // We're adding it manually as a temporary workaround
            System.Uri resourceLocater = new System.Uri("/ES_AIRAC_PCKGE;component/HomeGrid.xaml", System.UriKind.Relative);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }

        private void InitializeEventHandlers()
        {
            // Add event handlers for CheckBoxes
            foreach (var child in ((StackPanel)((StackPanel)((StackPanel)Content).Children[0]).Children[0]).Children)
            {
                if (child is CheckBox checkBox)
                {
                    checkBox.Checked += CheckBox_CheckedChanged;
                    checkBox.Unchecked += CheckBox_CheckedChanged;
                }
            }

            // Add event handler for Start button
            var startButton = ((Button)((StackPanel)((StackPanel)((StackPanel)Content).Children[0]).Children[1]).Children[0]);
            startButton.Click += StartButton_Click;
        }

        private void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            UpdateProgressBar();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement start functionality here
            MessageBox.Show("Start button clicked!");
        }

        private void UpdateProgressBar()
        {
            int checkedCount = 0;
            int totalCount = 0;

            foreach (var child in ((StackPanel)((StackPanel)((StackPanel)Content).Children[0]).Children[0]).Children)
            {
                if (child is CheckBox checkBox)
                {
                    totalCount++;
                    if (checkBox.IsChecked == true)
                    {
                        checkedCount++;
                    }
                }
            }

            var progressBar = (ProgressBar)((Grid)Content).Children[1];
            progressBar.Value = (double)checkedCount / totalCount * 100;
        }
    }
}