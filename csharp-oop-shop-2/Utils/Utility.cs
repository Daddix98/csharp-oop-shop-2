using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2.Utils
{
    internal class Utility
    {
        public const double LITRI_GALLONI = 3.785;
        public static double ConvertiInGalloni(double litri)
        {

            return LITRI_GALLONI * litri;

        }
    }
}
