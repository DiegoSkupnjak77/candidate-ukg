using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TraineeProgram.Domain.Exceptions;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services;
using TraineeProgram.Domain.Services.Interfaces;
using TraineeProgram.Persistence.DBEntities;
using TraineeProgram.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IJobOpeningRepository, JobOpeningRepository>();
builder.Services.AddScoped<IJobOpeningService, JobOpeningService>();
builder.Services.AddScoped<IOfferLetterRepository, OfferLetterRepository>();
builder.Services.AddScoped<IOfferLetterService, OfferLetterService>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IInterviewRepository, InterviewRepository>();
builder.Services.AddScoped<IInterviewService, InterviewService>();
builder.Services.AddDbContext<TraineeProgramDBContext>(dbContextOptions => dbContextOptions.UseSqlServer("Server=servertraineeprogram2.database.windows.net;User Id=techstar;Password=Rabbit99;Database=TraineeProgramDB;"));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

builder.Services.AddCors(options =>
{
    //options.AddPolicy(name: MyAllowSpecificOrigins,
    //                  policy =>
    //                  {
    //                      policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    //                  });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

//app.MapRazorPages();
//app.MapDefaultControllerRoute();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    //.RequireCors(MyAllowSpecificOrigins);

});

app.Run();

