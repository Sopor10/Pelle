namespace Application;

using System.Net;
using CommunityToolkit.Maui.Core.Primitives;

public partial class VideoPage : ContentPage
{

    public VideoPage()
    {
        InitializeComponent();
        
    }

    private void MediaElement_OnMediaFailed(object sender, MediaFailedEventArgs e)
    {
        throw new NotImplementedException();
    }
}

public record VideoViewModel(string FileName)
{
    
    public string FilePath
    {
        get
        {
            var currentAppDataDirectory = "/storage/emulated/0/Android/data/com.pelle.bmo";
            var filename = FileName.Split("/").Last().Split(".").First();
            
            return WebUtility.UrlDecode(Path.Join(currentAppDataDirectory, "vid", filename + ".mp4"));
        }
    }
}