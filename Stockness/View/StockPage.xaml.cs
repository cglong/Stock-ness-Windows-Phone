using Microsoft.Phone.Controls;
using Stockness.Model;
using Stockness.ViewModel;

namespace Stockness.View
{
    public partial class StockPage : PhoneApplicationPage
    {
        public StockPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var ViewModel = DataContext as IStockViewModel;

            ViewModel.Stock = new Stock
            {
                Symbol = NavigationContext.QueryString["symbol"],
            };
        }
    }
}