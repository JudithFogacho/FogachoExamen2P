using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogachoExamen2P.Models
{
    public class AFConversion
    {
        private readonly Dictionary<(AFTipoMoneda, AFTipoMoneda), decimal> exchangeRates = new() {
            { (AFTipoMoneda.AF_USD, AFTipoMoneda.AF_EUR), 0.95M},
            { (AFTipoMoneda.AF_USD, AFTipoMoneda.AF_COP), 4462M},
            { (AFTipoMoneda.AF_EUR, AFTipoMoneda.AF_USD), 1.05M},
            { (AFTipoMoneda.AF_EUR, AFTipoMoneda.AF_COP), 4669M},
            { (AFTipoMoneda.AF_COP, AFTipoMoneda.AF_USD), 0.00022M},
            { (AFTipoMoneda.AF_COP, AFTipoMoneda.AF_EUR), 0.00021M }
        };
    }
}
