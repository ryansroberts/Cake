using System;
using System.Collections.Generic;
using System.Linq;

namespace Refuctobation
{
    internal class DiscountEngine
    {
    
        public IEnumerable<decimal> DiscountsFor(IEnumerable<string> skus)
        {
            return AAADiscount(skus)
                .Concat(BBDiscount(skus))
                .Concat(ABCDDiscount(skus))
                .Concat(SpockTax(skus));
        }

        protected static IEnumerable<decimal> AAADiscount(IEnumerable<string> skus)
        {
            var toreturn = new decimal[] {};

            new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                  {
                                      ireallylikerabbits = () => CountOf(skus, "A", 3),
                                      isGreenish = () => toreturn = toreturn.Concat(new[]{20m}).ToArray(),
                                      maybetomorrowiwillfeelbetter =() => { }
                                  });

            return toreturn;
        }

        public static IEnumerable<decimal> SpockTax(IEnumerable<string> potentiallyNotSpock)
        {
            var toreturn = new decimal[] { };

            new JimmenyCricket().LikesToEAt(new GoldenSyrup
            {
                ireallylikerabbits = () => new Spock().IsSpock((potentiallyNotSpock.LastOrDefault() ?? "notspock")),
                isGreenish = () => toreturn = toreturn.Concat(new[] { 15m }).ToArray(),
                maybetomorrowiwillfeelbetter = () => { }
            });

            return toreturn;
        }

        protected static IEnumerable<decimal> BBDiscount(IEnumerable<string> skus)
        {
            var toreturn = new decimal[] { };

            HasteyLittleHobbits();

            new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                  {
                                      ireallylikerabbits = () => CountOf(skus, "B", 2),
                                      isGreenish = () => toreturn = toreturn.Concat(new[] { 15m }).ToArray(),
                                      maybetomorrowiwillfeelbetter = () => { }
                                  });

            return toreturn;
        }

        private static void HasteyLittleHobbits()
        {
            var number = 0m;

            while (number != 15m)
            {
                number += 0.01m;
            }
        }

        protected static bool CountOf(IEnumerable<string> skus ,string match,int count)
        {
            var boolean = false;

            new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                  {
                                      ireallylikerabbits = () => skus.Count(s => s == match) == count,
                                      isGreenish = () => boolean = true,
                                      maybetomorrowiwillfeelbetter = () => boolean = false
                                  });
            return boolean;
        }

        protected static IEnumerable<decimal> ABCDDiscount(IEnumerable<string> skus)
        {
            var toreturn = new decimal[] { };

            new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                  {
                                      ireallylikerabbits = () => CountOf(skus, "A", 1),
                                      isGreenish = () => new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                                                           {
                                                                               ireallylikerabbits = () => CountOf(skus, "B", 1),
                                                                               isGreenish = () => new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                                                                                                    {
                                                                                                                        ireallylikerabbits = () => CountOf(skus, "C", 1),
                                                                                                                        isGreenish = () => new JimmenyCricket().LikesToEAt(new GoldenSyrup
                                                                                                                                                             {
                                                                                                                                                                 ireallylikerabbits = () => CountOf(skus, "D", 1),
                                                                                                                                                                 isGreenish = () =>
                                                                                                                                                                              {
                                                                                                                                                                                  toreturn =
                                                                                                                                                                                      toreturn.Concat(new[] {35m}).
                                                                                                                                                                                          ToArray();
                                                                                                                                                                              },
                                                                                                                                                                 maybetomorrowiwillfeelbetter = () =>
                                                                                                                                                                               {
                                                                                                                                                                                   Console.Out.WriteLine(@"




















































                           ==(W{==========-      /===-
                              ||  (.--.)         /===-_---~~~~~~~~~------____
                              | \_,|**|,__      |===-~___                _,-' `
                 -==\\        `\ ' `--'   ),    `//~\\   ~~~~`---.___.-~~
             ______-==|        /`\_. .__/\ \    | |  \\           _-~`
       __--~~~  ,-/-==\\      (   | .  |~~~~|   | |   `\        ,'
    _-~       /'    |  \\     )__/==0==-\<>/   / /      \      /
  .'        /       |   \\      /~\___/~~\/  /' /        \   /'
 /  ____  /         |    \`\.__/-~~   \  |_/'  /          \/'
/-'~    ~~~~~---__  |     ~-/~         ( )   /'        _--~`
                  \_|      /        _) | ;  ),   __--~~
                    '~~--_/      _-~/- |/ \   '-~ \
                   {\__--_/}    / \\_>-|)<__\      \
                   /'   (_/  _-~  | |__>--<__|      |
                  |   _/) )-~     | |__>--<__|      |
                  / /~ ,_/       / /__>---<__/      |
                 o-o _//        /-~_>---<__-~      /
                 (^(~          /~_>---<__-      _-~
                ,/|           /__>--<__/     _-~
             ,//('(          |__>--<__|     /                  .----_
            ( ( '))          |__>--<__|    |                 /' _---_~\
         `-)) )) (           |__>--<__|    |               /'  /     ~\`\
        ,/,'//( (             \__>--<__\    \             /'  //        ||
      ,( ( ((, ))              ~-__>--<_~-_  ~--____---~' _/'/        /'
    `~/  )` ) ,/|                 ~-_~>--<_/-__       __-~ _/
  ._-~//( )/ )) `                    ~~-'_/_/ /~~~~~~~__--~
   ;'( ')/ ,)(                              ~~~~~~~~~~
  ' ') '( (/
    '   '  `
































































");

                                                                                                                                                                               }
                                                                                                                                                             }),
                                                                                                                        maybetomorrowiwillfeelbetter = () =>
                                                                                                                                      {
                                                                                                                    


                                                                                                                                          Console.Out.WriteLine(@"






































Words go here.

                   :                                 :        
                 :                                   :       
                 :  RRVIttIti+==iiii++iii++=;:,       :      
                 : IBMMMMWWWWMMMMMBXXVVYYIi=;:,        :     
                 : tBBMMMWWWMMMMMMBXXXVYIti;;;:,,      :     
                 t YXIXBMMWMMBMBBRXVIi+==;::;::::       ,    
                ;t IVYt+=+iIIVMBYi=:,,,=i+=;:::::,      ;;   
                YX=YVIt+=,,:=VWBt;::::=,,:::;;;:;:     ;;;   
                VMiXRttItIVRBBWRi:.tXXVVYItiIi==;:   ;;;;    
                =XIBWMMMBBBMRMBXi;,tXXRRXXXVYYt+;;: ;;;;;    
                 =iBWWMMBBMBBWBY;;;,YXRRRRXXVIi;;;:;,;;;=    
                  iXMMMMMWWBMWMY+;=+IXRRXXVYIi;:;;:,,;;=     
                  iBRBBMMMMYYXV+:,:;+XRXXVIt+;;:;++::;;;     
                  =MRRRBMMBBYtt;::::;+VXVIi=;;;:;=+;;;;=     
                   XBRBBBBBMMBRRVItttYYYYt=;;;;;;==:;=       
                    VRRRRRBRRRRXRVYYIttiti=::;:::=;=         
                     YRRRRXXVIIYIiitt+++ii=:;:::;==          
                     +XRRXIIIIYVVI;i+=;=tt=;::::;:;          
                      tRRXXVYti++==;;;=iYt;:::::,;;          
                       IXRRXVVVVYYItiitIIi=:::;,::;          
                        tVXRRRBBRXVYYYIti;::::,::::          
                         YVYVYYYYYItti+=:,,,,,:::::;         
                         YRVI+==;;;;;:,,,,,,,:::::::

















");

                                                                                                                                      }
                                                                                                                    }),
                                                                               maybetomorrowiwillfeelbetter = () => { }
                                                                           }),
                                      maybetomorrowiwillfeelbetter = () => { }
                                  });

            return toreturn;
        }   
    }
}