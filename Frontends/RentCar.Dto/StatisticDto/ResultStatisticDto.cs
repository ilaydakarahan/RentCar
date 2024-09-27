using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Dto.StatisticDto
{
    public class ResultStatisticDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgPriceForDaily { get; set; }
        public decimal avgPriceForWeekly { get; set; }
        public decimal avgPriceForMonthly { get; set; }
        public int carCountByTransmissionIsAutoCount { get; set; }
        public int carCountByKmSmallerThen1000 { get; set; }
        public int carCountByFuelGosalineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string brandAndModelByRentPriceDailyMax { get; set; }
        public string brandAndModelByRentPriceDailyMin { get; set; }
        public string brandName { get; set; }
        public string title { get; set; }
    }
}
