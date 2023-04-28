using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

builder.Services.AddScoped<ISliderPhotoService, SliderPhotoManager>();
builder.Services.AddScoped<ISliderPhotoDal, EfSliderPhotoDal>();

builder.Services.AddScoped<INewArrivalService, NewArrivalManager>();
builder.Services.AddScoped<INewArrivalDal, EfNewArrivalDal>();

builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogDal, EfBlogDal>();


builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<IBrandDal, EfBrandDal>();

builder.Services.AddScoped<IPolicyService, PolicyManager>();
builder.Services.AddScoped<IPolicyDal, EfPolicyDal>();

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();

builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogDal, EfBlogDal>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.Run();
