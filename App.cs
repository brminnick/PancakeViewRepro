using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace PancakeViewRepro
{
    public class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new PancakeView()
            };
        }
    }
}
