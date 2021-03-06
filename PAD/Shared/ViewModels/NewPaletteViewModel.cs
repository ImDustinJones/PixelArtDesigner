using PAD.Data.Models;

namespace PAD.Shared.ViewModels
{
    public class NewPalettetViewModel : ViewModel
    {
        public string BaseImageUrl { get; set; }
        public Palette Palette = new();
        public string[] SelectedColorArray = new string[10];
    }
}
