using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DXFactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            tbScrFld.Text = String.Empty;
            tbDstFld.Text = String.Empty;
            

        }


        private void ToolBar_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                ToolBar toolBar = sender as ToolBar;
                var overflowGrid = toolBar.Template.FindName("OverflowGrid", toolBar) as FrameworkElement;
                if (overflowGrid != null)
                {
                    overflowGrid.Visibility = Visibility.Collapsed;
                }

                var mainPanelBorder = toolBar.Template.FindName("MainPanelBorder", toolBar) as FrameworkElement;
                if (mainPanelBorder != null)
                {
                    mainPanelBorder.Margin = new Thickness(0);
                }
            }

        }



        private void btnScrSearch_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new OpenFolderDialog
            {
                // Set options here
                

            };

            if (folderDialog.ShowDialog() == true)
            {
                tbScrFld.Text = folderDialog.FolderName;
            }
        }

        private void btnDstSearch_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new OpenFolderDialog
            {
                // Set options here
                InitialDirectory = tbScrFld.Text

            };

            if (folderDialog.ShowDialog() == true)
            {
                tbDstFld.Text = folderDialog.FolderName;
            }
        }
    }
}