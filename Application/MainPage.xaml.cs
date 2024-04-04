namespace Application;


public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        
    }

    private void WebView_OnNavigating(object sender, WebNavigatingEventArgs e)
    {
        if (e.Url.Contains("vid"))
        {
            e.Cancel = true;
            var videoViewModel = new VideoViewModel(e.Url);

            //if (DeviceInfo.Current.Platform == DevicePlatform.Android)
            //{
            //    try
            //    {
            //        var videoFile = new Java.IO.File(Java.Net.URI.Create($"file://{videoViewModel.FilePath}"));
            //        Android.Net.Uri fileUri = FileProvider.GetUriForFile(Android.App.Application.Context, $"{Android.App.Application.Context.PackageName}.fileprovider", videoFile);
            //        Intent intent = new Intent();
            //        intent.SetAction(Intent.ActionView);
            //        intent.AddFlags(ActivityFlags.NewTask);
            //        intent.AddFlags(ActivityFlags.GrantReadUriPermission);
            //        intent.SetDataAndType(fileUri, "video/*");
            //        Android.Application.Context.ApplicationContext.StartActivity(intent);
            //    }
            //    catch(Exception ex)
            //    { 

            //    }
            //}

            this.Navigation.PushAsync(new VideoPage()
                {
                    BindingContext = videoViewModel
                });
                
        }
    }
}
