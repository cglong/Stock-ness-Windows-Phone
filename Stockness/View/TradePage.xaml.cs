using Microsoft.Phone.Controls;
using Stockness.Model;
using Stockness.ViewModel;
namespace Stockness.View
{
    public partial class TradePage : PhoneApplicationPage
    {
        public TradePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var ViewModel = DataContext as ITradeViewModel;

            ViewModel.Stock = new Stock
            {
                Symbol = NavigationContext.QueryString["symbol"],
            };
        }
    }
}