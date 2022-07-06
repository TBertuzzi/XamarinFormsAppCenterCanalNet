using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsAppCenter.ViewModels;

namespace XamarinFormsAppCenter.Views
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