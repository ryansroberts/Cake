using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refuctobation
{
    public class Checkout
    {

        public class Class11
        {
            public string Sku { get; set; }
            public decimal Price { get; set; }
        }
 
        IList<Class11> _items;

        public Checkout()
        {
            _items = new List<Class11>();
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
            this._items.Add(new Class11 {Price = price, Sku = sku});

            return price;
        }

        public void VoidItem(string sku)
        {
            this._items.Remove(this._items.First(i => i.Sku == sku));
        }

    }
}
