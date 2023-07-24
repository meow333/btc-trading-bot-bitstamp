using System;
using System.Diagnostics;
using System.Reflection;
using TradingViewTradePanelOanda;
using TradingViewUdfProvider;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddTradingViewProvider<MyTvProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

    app.UseDeveloperExceptionPage();

}

//app.UseHttpsRedirection();
app.UseStaticFiles();


// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
// specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.UseRouting();

app.UseAuthorization();

/*app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});*/

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

// Optional TradingView provider settings
app.UseTradingViewProvider(new TradingViewSettings());

var browserExecutable = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
Process.Start(browserExecutable, "http://localhost:5000");

app.Run();
