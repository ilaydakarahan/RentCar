using Microsoft.EntityFrameworkCore;
using RentCar.Application.Interfaces.StatisticInterfaces;
using RentCar.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Persistance.Repositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly RentCarContext _context;

        public StatisticRepository(RentCarContext context)
        {
            _context = context;
        }

        public async Task<int> GetAuthorCount()
        {
            return await _context.Authors.CountAsync();
        }

        public async Task<decimal> GetAvgRentPriceForDaily()
        {
            //ödeme şekli(pricing) adı günlük olanın pricingıd sini seç.firstordefault ile yakala
            int id = _context.Pricings.Where(x => x.Name == "Günlük").Select(z => z.PricingId).FirstOrDefault();
            //carpricing de pricingid si yukarıdaki id olana eşitle ve bu carpricinglerin amountun ortalamasını al.
            return await _context.CarPricings.Where(y => y.PricingId == id).AverageAsync(q => q.Amount);
        }

        public async Task<decimal> GetAvgRentPriceForMonthly()
        {
            int id = _context.Pricings.Where(y => y.Name == "Aylık").Select(z => z.PricingId).FirstOrDefault();
            return await _context.CarPricings.Where(x => x.PricingId == id).AverageAsync(t => t.Amount);
        }

        public async Task<decimal> GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(y => y.Name == "Haftalık").Select(z => z.PricingId).FirstOrDefault();
            return await _context.CarPricings.Where(x => x.PricingId == id).AverageAsync(t => t.Amount);
        }

        public async Task<int> GetBlogCount()
        {
            return await _context.Blogs.CountAsync();
        }
        public async Task<string> GetBrandNameByMaxCar()
        {
            var brandName = await _context.Cars.GroupBy(x => x.BrandId).Select(y => new
                {
                    BrandId = y.Key,
                    Count = y.Count()
                }).OrderByDescending(t=>t.Count).Take(1).Select(z=>z.BrandId).FirstOrDefaultAsync();

            return await _context.Brands.Where(x => x.BrandId == brandName).Select(z => z.Name).FirstOrDefaultAsync();

        }
        public async Task<string> GetBlogTitleMaxBlogComment()
        {
            //// En fazla yoruma sahip blogun id'si
            //var values = await _context.Comments.GroupBy(x => x.BlogId).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefaultAsync(); 
            //// En fazla yoruma sahip blogun başlığı
            //var blogTitle = await _context.Blogs.Where(x => x.BlogId == values).Select(x => x.Title).FirstOrDefaultAsync(); 
            //return blogTitle ?? "Blog bulunamadı";

            var value = await _context.Comments.GroupBy(t => t.BlogId).Select(y => new
            {
                BlogId = y.Key,
                Count = y.Count()
            }).OrderByDescending(z => z.Count).Take(1).Select(t => t.BlogId).FirstOrDefaultAsync();

            return await _context.Blogs.Where(x => x.BlogId == value).Select(z => z.Title).FirstOrDefaultAsync();
        }

        public async Task<string> GetBrandAndModelByRentPriceDailyMax()
        {
            int pricingId = _context.Pricings.Where(t => t.Name == "Günlük").Select(t => t.PricingId).FirstOrDefault();
            var amount = _context.CarPricings.Where(y => y.PricingId == pricingId).Max(y => y.Amount);
            int CarId = _context.CarPricings.Where(z => z.Amount == amount).Select(u => u.CarId).FirstOrDefault();

            string brandModel = await _context.Cars.Where(x => x.CarId == CarId).Include(v => v.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefaultAsync();
            return brandModel;
        }

        public async Task<string> GetBrandAndModelByRentPriceDailyMin()
        {
            //var values = await _context.CarPricings.Where(x => x.PricingId == 2).OrderBy(x => x.Amount).Select(x => x.CarId).FirstOrDefaultAsync();
            //var carModel = await _context.Cars.Where(x => x.CarId == values).Select(x => x.Model).FirstOrDefaultAsync();
            //return carModel ?? "Araç bulunamadı";
            //Bu sorgu da çalışıyor ancak sadece model adı geliyor marka adı gelmiyor.

            int pricingId = _context.Pricings.Where(t => t.Name == "Günlük").Select(t => t.PricingId).FirstOrDefault();
            var amount = _context.CarPricings.Where(t => t.PricingId == pricingId).Min(t => t.Amount);
            int CarId = _context.CarPricings.Where(t => t.Amount == amount).Select(u => u.CarId).FirstOrDefault();

            string brandModel = await _context.Cars.Where(x => x.CarId == CarId).Include(v => v.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefaultAsync();
            return brandModel;
        }
        public async Task<int> GetBrandCount()
        {
            return await _context.Brands.CountAsync();
        }
        public async Task<int> GetCarCount()
        {
            var value = await _context.Cars.CountAsync();
            return value;
        }

        public async Task<int> GetCarCountByFuelGasolineOrDisel()
        {
            return await _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").CountAsync();
        }

        public async Task<int> GetCarCountByKmSmallarThen1000()
        {
            return await _context.Cars.Where(x => x.Km <= 1000).CountAsync();
        }

        public async Task<int> GetCarCountByTranmissionIsAuto()
        {
            return await _context.Cars.Where(x => x.Transmission == "Otomatik").CountAsync();
        }

        public async Task<int> GetCarCountFuelElectric()
        {
            return await _context.Cars.Where(x => x.Fuel == "Elektrik").CountAsync();
        }

        public async Task<int> GetLocationCount()
        {
            return await _context.Locations.CountAsync();
        }
    }
}
