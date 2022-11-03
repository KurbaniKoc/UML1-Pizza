using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class MedlemsFordele
    {
        private static int nextId = 1;
        public MedlemsFordele(int id, string discounts, string freePrizes, string weeklyGifts)
        {
            Id = id;
            Discounts = discounts;
            FreePrizes = freePrizes;
            WeeklyGifts = weeklyGifts;
        }
        public int Id { get; set; }
        public string Discounts { get; set; }
        public string FreePrizes { get; set; }
        public string WeeklyGifts { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Discounts)}={Discounts}, {nameof(FreePrizes)}={FreePrizes}, {nameof(WeeklyGifts)}={WeeklyGifts}}}";
        }
    }
    }


   
