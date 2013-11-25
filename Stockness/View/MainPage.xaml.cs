using Microsoft.Phone.Controls;
using Stockness.ViewModel;
using System;
using System.Windows;
using Telerik.Windows.Controls;

namespace Stockness.View
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            DisplayLoginPrompt();
        }

        private void DisplayLoginPrompt()
        {
            Style usernameStyle = new Style(typeof(RadTextBox));
            usernameStyle.Setters.Add(new Setter(RadTextBox.HeaderProperty, "username"));
            Style passwordStyle = new Style(typeof(RadPasswordBox));
            passwordStyle.Setters.Add(new Setter(RadPasswordBox.HeaderProperty, "password"));

            InputPromptSettings settings = new InputPromptSettings();
            settings.Field1Mode = InputMode.Text;
            settings.Field1Style = usernameStyle;
            settings.Field2Mode = InputMode.Password;
            settings.Field2Style = passwordStyle;

            string messageTitle = "Stockness Monster";
            string messageText = "Please enter your login information:";

            RadInputPrompt.Show(settings, messageTitle, MessageBoxButtons.OKCancel, messageText, closedHandler:LogIn);
        }

        private void LogIn(InputPromptClosedEventArgs e)
        {
            (DataContext as IMainViewModel).LogIn(e.Text, e.Text2);
        }
    }
}