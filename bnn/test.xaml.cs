using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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

namespace bnn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class test : Page
    {
        private Class1 test1;
        public test()
        {
            this.InitializeComponent();
            this.test1 = new Class1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.test1.link = "https://www.facebook.com/";
            string jsonMember = JsonConvert.SerializeObject(this.test1);

            HttpClient httpClient = new HttpClient();
            var content = new StringContent(jsonMember, Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync(Service.ServiceUrl.MEMBER_INFORMATION, content).Result;

            Debug.WriteLine(jsonMember);
        }
    }
}
