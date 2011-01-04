using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using Refuctobation;

namespace Spec.ctxt
{
    public class with_checkout : with_auto_mocking<Checkout>
    {
        private static decimal price;

        protected static void scanning(string s)
        {
            price = class_under_test.Scan(s);
        }

        protected static void scan_and_void(IEnumerable<string> scannedSkus, IEnumerable<string> voidSkus)
        {
            scanning(scannedSkus);
            voidItems(voidSkus);
        }

        private static void voidItems(IEnumerable<string> voidSkus)
        {
            foreach (var sku in voidSkus)
                class_under_test.VoidItem(sku); 
        }

        protected static void scanning(IEnumerable<string> skus)
        {
            foreach (var sku in skus)
                class_under_test.Scan(sku);
            
            price = class_under_test.TotalCost;
        }

        protected static void total_cost(decimal shouldbe)
        {
            class_under_test.TotalCost.ShouldEqual(shouldbe);
        }
    }
}