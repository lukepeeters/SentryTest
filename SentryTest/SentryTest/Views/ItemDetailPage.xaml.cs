using SentryTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SentryTest.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}