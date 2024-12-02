using FogachoExamen2P.Models;
using Microsoft.VisualBasic;

namespace FogachoExamen2P
{
    public partial class AFMainPage : ContentPage
    {
        private readonly AFConversion conversion = new ();
        public AFMainPage()
        {
            InitializeComponent();
            InitializePickers();

        }
        private void InitializePickers() {
            var currencies = Enum.GetValues(typeof(AFTipoMoneda)).Cast<AFTipoMoneda>().Select(c => c.ToString()).ToList();
            FromCurrencyPicker.ItemsSource = currencies;
            ToCurrencyPicker.ItemsSource = currencies;
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            if (decimal.TryParse(AmountEntry.Text, out decimal amount) && 
                Enum.TryParse(FromCurrencyPicker.SelectedItem?.ToString(), out AFTipoMoneda fromCurrency) &&
                Enum.TryParse(ToCurrencyPicker.SelectedItem?.ToString(), out AFTipoMoneda toCurrency))
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
