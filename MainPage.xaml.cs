using FogachoExamen2P.Models;

namespace FogachoExamen2P
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //InitializePickers();

        }
        /*private void InitializePickers() {
            var conversiones = Enum.GetValues(typeof(AFTipoMoneda));
            FromCurrencyPicker.ItemsSource = conversiones;
            ToCurrencyPicker.ItemsSource = conversiones;
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            if(decimal)

        }*/
    }

}
