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
            var currentAppDataDirectory = "/storage/emulated/0/Android/data/com.companyname.application";
            var filename = FileName.Split("/").Last().Split(".").First();
            
            return WebUtility.UrlDecode(Path.Join(currentAppDataDirectory, "vid", filename + ".mp4"));
        }
    }
}