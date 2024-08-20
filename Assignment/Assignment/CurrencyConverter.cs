using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CurrencyConverter
    {
        private static int ConversionCount=0;
        public string FromCurrency { get; set; } = "USD";
        public string ToCurrency { get; set; } ="EUR";
        public double ExchangeRate { get; set; } = 83.78;
        
        public CurrencyConverter() { }
        public CurrencyConverter(String FromCurrency, String ToCurrency, double ExchangeRate) {
            this.FromCurrency = FromCurrency;
            this.ToCurrency = ToCurrency;
            this.ExchangeRate = ExchangeRate;
        }

        static void IncrementConversionCount() {
            ConversionCount++;
        }

        static void ShowConversionCount() {
            Console.WriteLine(ConversionCount);
                }

        public double ConvertAmount(double amount)
        {
            IncrementConversionCount();
            return amount * this.ExchangeRate;
        }

        public double ConvertAmount(double amount, double customRate){
            IncrementConversionCount();
            return amount* customRate;

    }


    }


   
}
