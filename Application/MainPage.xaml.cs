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
            
            Navigation.PushAsync(new VideoPage()
            {
                BindingContext = new VideoViewModel(e.Url)
            });
            
        }
    }
}