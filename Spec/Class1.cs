using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Refuctobation;

namespace Spec
{
    public class cost_of_A : ctxt.with_checkout
    {
        Because of = () => scanning("A");

        It costs_50 =()=> total_cost(50);
    }

    public class cost_of_B : ctxt.with_checkout
    {
        Because of = () => scanning("B");

        It costs_30 = () => total_cost(30);
    }

    public class cost_of_C : ctxt.with_checkout
    {
        Because of = () => scanning("C");

        It costs_20 = () => total_cost(20);
    }

    public class cost_of_D : ctxt.with_checkout
    {
        Because of = () => scanning("D");

        It costs_15 = () => total_cost(15);
    }

    public class cost_of_AA : ctxt.with_checkout
    {
        Because of = () => scanning(new[]{"A","A"});
        
        It costs_100 = () => total_cost(100);
    }

    public class cost_of_AAA : ctxt.with_checkout
    {
        Because of = () => scanning(new[] { "A", "A", "A" });

        It costs_130 = () => total_cost(130);
    }

    public class cost_of_BB : ctxt.with_checkout
    {
        Because of = () => scanning(new[] { "B", "B"});

        It costs_45 = () => total_cost(45);
    }

    public class void_Of_B : ctxt.with_checkout
    {
        Because of = () => scan_and_void(new[] { "B" }, new[] { "B" });

        It costs_0 = () => total_cost(0);
    }

    public class void_Of_BB : ctxt.with_checkout
    {
        Because of = () => scan_and_void(new[] { "B","B" }, new[] { "B" });

        It costs_0 = () => total_cost(30);
    }

    public class cost_of_ABCD : ctxt.with_checkout
    {
        Because of = () => scanning(new[] { "A", "B", "C", "D" });

        It costs_80 = () => total_cost(80);
    }

    public class reciepts_dont_suck : ctxt.with_checkout
    {
         It has_reciept = () =>
                              {
                                  new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                                        {
                                                            ireallylikerabbits = () => true,
                                                            isGreenish = () => Console.WriteLine("awesome")
                                                        });
                              };
    }
}
