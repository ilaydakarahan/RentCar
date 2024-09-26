using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Interfaces.StatisticInterfaces
{
    public interface IStatisticRepository
    {
        Task<int> GetCarCount();
        Task<int> GetLocationCount();
        Task<int> GetAuthorCount();
        Task<int> GetBlogCount();
        Task<int> GetBrandCount();
        Task<decimal> GetAvgRentPriceForDaily();
        Task<decimal> GetAvgRentPriceForWeekly();
        Task<decimal> GetAvgRentPriceForMonthly();
        Task<int> GetCarCountByTranmissionIsAuto();
        Task<string> GetBrandNameByMaxCar();
        Task<string> GetBlogTitleMaxBlogComment();
        Task<int> GetCarCountByKmSmallarThen1000();
        Task<int> GetCarCountByFuelGasolineOrDisel();
        Task<int> GetCarCountFuelElectric();
        Task<string> GetBrandAndModelByRentPriceDailyMax();
        Task<string> GetBrandAndModelByRentPriceDailyMin();
    }
}
