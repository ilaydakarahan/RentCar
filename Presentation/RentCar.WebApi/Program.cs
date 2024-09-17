using RentCar.Application.Features.CQRS.Handlers.AboutHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.AboutHandlers.Write;
using RentCar.Application.Features.CQRS.Handlers.BannerHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.BannerHandlers.Write;
using RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.BlogCategoryHandlers.Write;
using RentCar.Application.Features.CQRS.Handlers.BrandHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.BrandHandlers.Write;
using RentCar.Application.Features.CQRS.Handlers.CarHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.CarHandlers.Write;
using RentCar.Application.Features.CQRS.Handlers.ContactHandlers.Read;
using RentCar.Application.Features.CQRS.Handlers.ContactHandlers.Write;
using RentCar.Application.Features.RepositoryPattern;
using RentCar.Application.Interfaces;
using RentCar.Application.Interfaces.BlogInterfaces;
using RentCar.Application.Interfaces.CarPricingInterfaces;
using RentCar.Application.Interfaces.TagCloudInterfaces;
using RentCar.Application.Services;
using RentCar.Persistance.Context;
using RentCar.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RentCarContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddScoped<ITagCloudRepository, TagCloudRepository>();
builder.Services.AddScoped<ICarPricingRepository, CarPricingRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();


builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();

builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();

builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();        //cqrs le yazýldýðý için eklemeliyiz.
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();

builder.Services.AddScoped<GetBlogCategoryByIdQueryHandler>();
builder.Services.AddScoped<GetBlogCategoryQueryHandler>();
//builder.Services.AddScoped<GetLast3BlogsWithAutorsQueryHandler>();  //Mediator le yazýldýðý için buna gerek kalmadý
builder.Services.AddScoped<CreateBlogCategoryCommandHandler>();
builder.Services.AddScoped<RemoveBlogCategoryCommandHandler>();
builder.Services.AddScoped<UpdateBlogCategoryCommandHandler>();

builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();


builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
