using FluentValidation.AspNetCore;
using FluentValidation;
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
using RentCar.Application.Interfaces.CarDescriptionInterfaces;
using RentCar.Application.Interfaces.CarPricingInterfaces;
using RentCar.Application.Interfaces.ICarFeatureInterfaces;
using RentCar.Application.Interfaces.RentACarInterfaces;
using RentCar.Application.Interfaces.ReviewInterfaces;
using RentCar.Application.Interfaces.StatisticInterfaces;
using RentCar.Application.Interfaces.TagCloudInterfaces;
using RentCar.Application.Services;
using RentCar.Application.Validators.ReviewValidators;
using RentCar.Persistance.Context;
using RentCar.Persistance.Repositories;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using RentCar.Application.Tools;
using RentCar.WebApi.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();

builder.Services.AddCors(opts =>
{
    opts.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed((host) => true).AllowCredentials();
    });
});

builder.Services.AddSignalR();

//JWT tanýmlama
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opts =>
{
    opts.RequireHttpsMetadata = false;
    opts.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
    };
});



// Add services to the container.
builder.Services.AddDbContext<RentCarContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<ICarDescriptionRepository, CarDescriptionRepository>();
builder.Services.AddScoped<IRentACarRepository, RentACarRepository>();
builder.Services.AddScoped<IStatisticRepository, StatisticRepository>();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddScoped<ITagCloudRepository, TagCloudRepository>();
builder.Services.AddScoped<ICarPricingRepository, CarPricingRepository>();
builder.Services.AddScoped<ICarFeatureRepository, CarFeatureRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));



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

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<CreateReviewValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateReviewValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<CarHub>("/carhub");
app.Run();
