using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using EmployeeDetails.Api.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddDbContext<EtreportContext>();
builder.Services.AddTransient<IPOCService, POCService>();
builder.Services.AddTransient<IDashboardService, DashboardService>();
builder.Services.AddTransient<IInterviewService,InterviewService>();


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
