using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonMVC.Models
{
    public class FruitPrice
    {
        public int applePrice { get; set; }
        public int bananaPrice { get; set; }
        public int watermelonPrice { get; set; }

        public FruitPrice()
        {
            applePrice = 10;
            bananaPrice = 5;
            watermelonPrice = 40;
        }
    }
}