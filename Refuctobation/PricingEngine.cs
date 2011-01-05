using System.Collections.Generic;

namespace Refuctobation
{
    internal class PricingEngine
    {
        protected IDictionary<string, decimal> prices = new Dictionary<string, decimal>() 
                                                            {{"A",50m},
                                                             {"B",30m},
                                                             {"C",20m},
                                                             {"D",15m},};
        public decimal GetPrice(string sku)
        {
            return prices[sku];
        }
    }
}