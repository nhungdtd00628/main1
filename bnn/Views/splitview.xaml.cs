using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace bnn.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class splitview : Page
    {
        private String CurrentTag = "";
        internal static string currentMemberId;

        public splitview()
        {
            this.InitializeComponent();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (CurrentTag == radio.Tag.ToString())
            {
                return;
            }
            switch (radio.Tag.ToString())
            {
                case "MyAccount":
                    CurrentTag = "MyAccount";
                    this.myframe.Navigate(typeof(Views.Submit));
                    break;
                case "Register":
                    CurrentTag = "Register";
                    this.myframe.Navigate(typeof(MainPage));
                    break;
                case "Other":
                    CurrentTag = "Other";
                    this.myframe.Navigate(typeof(Assets.AlignWith));
                    break;
                default:
                    break;
            }
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen;
        }
    }
}


