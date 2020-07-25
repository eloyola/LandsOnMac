namespace Lands.Views
{
    using Xamarin.Forms;

    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            App.Navigator = Navigator;
        }
    }
}
