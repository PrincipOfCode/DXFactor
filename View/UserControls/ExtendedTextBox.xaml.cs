using System.Windows;
using System.Windows.Controls;


namespace DXFactor.View.UserControls
{
    /// <summary>
    /// Interaction logic for ExtendedTextBox.xaml
    /// </summary>
    public partial class ExtendedTextBox : UserControl
    {
        public ExtendedTextBox()
        {
            InitializeComponent();
        }

        private string placeholder = string.Empty;

        public string Placeholder
        { 
            get { return placeholder; } 
            set { 
                placeholder = value; 

                // do not do this
                tbPlaceholder.Text = placeholder;

                // onPropertyChanget();
            } 
        }

        



        private void btnClear_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            tbInput.Clear();
            tbInput.Focus();


        }

        private void tbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else
                tbPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}
