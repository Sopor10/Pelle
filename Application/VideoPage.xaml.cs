namespace Application;

using System.Net;

public partial class VideoPage : ContentPage
{

    public VideoPage()
    {
        InitializeComponent();
        
    }
    
}

public record VideoViewModel(string FileName)
{
    
    public string FilePath
    {
        get
        {
            var currentAppDataDirectory = Microsoft.Maui.Storage.FileSystem.Current.AppDataDirectory;
            var filename = FileName.Split("/").Last();
            
            return WebUtility.UrlDecode(Path.Join(currentAppDataDirectory, "vid", filename));
        }
    }
}