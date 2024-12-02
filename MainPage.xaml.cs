using FogachoExamen2P.Models;
using Microsoft.VisualBasic;

namespace FogachoExamen2P
{
    public partial class MainPage : ContentPage
    {
        private readonly AFConversion conversion = new ();
        public MainPage()
        {
            InitializeComponent();
            //InitializePickers();

        }
        private void InitializePickers() {
            var currencies = Enum.GetValues(typeof(AFTipoMoneda));
            FromCurrencyPicker.ItemsSource = currencies;
            ToCurrencyPicker.ItemsSource = currencies;
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountEntry.Text, out decimal amount) && FromCurrencyPicker.SelectedItem is AFTipoMoneda fromCurrency
                && ToCurrencyPicker.SelectedItem is AFTipoMoneda toCurrency)
            {
                try
                {
                    var result = conversion.Conversion(fromCurrency, toCurrency, amount);
                    ResultLabel.Text = $"Resultado: {result:F2} {toCurrency}";

                }
                catch (Exception ex)
                {
                    ResultLabel.Text = $"Error: {ex.Message}";
                }

            }
            else {
                ResultLabel.Text = " Ingrese valores validos";
            }

        }
    }

}
