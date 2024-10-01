using Java.Lang;
using MauiCRUD.ViewModels;

namespace MauiCRUD
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductsViewModel _productsViewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = productsViewModel;
            _productsViewModel = ProductsViewModel;
        }

        protected async Override async void OnAppearing()
        {
            base.OnAppearing();
            await _productsViewModel.LoadProductsAsync();
        }


    }

}
