using LoginAuthProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginAuthProject.Views
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