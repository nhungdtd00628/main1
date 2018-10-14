using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
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
    public sealed partial class b1 : Page
    {
        public b1()
        {
            this.InitializeComponent();
        }

        private async void Click_save(object sender, RoutedEventArgs e)
        {
            string content = Filecontent.Text;
            string fileName = FileName.Text;
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            savePicker.SuggestedFileName = fileName;
            StorageFile file = await savePicker.PickSaveFileAsync();


           // Windows.Storage.StorageFolder folder = Windows.Storage.ApplicationData.Current.LocalCacheFolder;
            //Windows.Storage.StorageFile file = await folder.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.OpenIfExists);
            await Windows.Storage.FileIO.WriteTextAsync(file, content);
            
               

        }

        private async void click_Load(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".txt");
            StorageFile file = await openPicker.PickSingleFileAsync();
           
            //string fileName = FileName.Text;
            //Windows.Storage.StorageFolder folder = Windows.Storage.ApplicationData.Current.LocalCacheFolder;
            //Windows.Storage.StorageFile file = await folder.GetFileAsync(fileName);
           String content = await Windows.Storage.FileIO.ReadTextAsync(file);
            Filecontent.Text = content;
        }
    }
}
