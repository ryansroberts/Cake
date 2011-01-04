using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refuctobation
{
    public class Checkout
    {

        public class Item
        {
            public string Sku { get; set; }
            public decimal Price { get; set; }
        }
 
        IList<Item> _items;

        public Checkout()
        {
            _items = new List<Item>();
        }

        public decimal TotalCost
        {
            get
            {
                var discountEngine = new DiscountEngine();
                return _items.Sum(s => s.Price) -
                    discountEngine.DiscountsFor(_items.Select(s => s.Sku)).Sum();
            }
        }
        public decimal Scan(string sku)
        {
            PricingEngine pe = new PricingEngine();
            decimal price = pe.GetPrice(sku);
            this._items.Add(new Item {Price = price, Sku = sku});

            return price;
        }

        public void VoidItem(string sku)
        {
            this._items.Remove(this._items.First(i => i.Sku == sku));
        }

    }

    internal class DiscountEngine
    {
    
        public IEnumerable<decimal> DiscountsFor(IEnumerable<string> skus)
        {
             return AAADiscount(skus)
                 .Concat(BBDiscount(skus))
                 .Concat(ABCDDiscount(skus));
        }

        protected static IEnumerable<decimal> AAADiscount(IEnumerable<string> skus)
        {
            if (CountOf(skus,"A",3))
                yield return 20;
        }

        protected static IEnumerable<decimal> BBDiscount(IEnumerable<string> skus)
        {
            if (CountOf(skus, "B", 2))
                yield return 15;
        }

        protected static bool CountOf(IEnumerable<string> skus ,string match,int count)
        {
            return skus.Count(s => s == match) == count;
        }

        protected static IEnumerable<decimal> ABCDDiscount(IEnumerable<string> skus)
        {
            if (CountOf(skus, "A", 1) && 
                CountOf(skus, "B", 1) && 
                CountOf(skus, "C", 1) && 
                CountOf(skus, "D", 1))
                yield return 35;
        }   
    }

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
