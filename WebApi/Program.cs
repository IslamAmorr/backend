
using Application.Interfaces;
using Application.Interfaces.IRepository;
using Application.Interfaces.IService;
using Application.Interfaces.IServices;
using Application.Mapping;
using Application.Services;
using AutoMapper;
using Domain.DTOs;
using Domain.models;
using Infrastructure.Hubs;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Infrastructure.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// --- AutoMapper ---
builder.Services.AddAutoMapper(typeof(CustomerProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AlertProfile).Assembly);
builder.Services.AddAutoMapper(typeof(EquipmentProfile).Assembly);
builder.Services.AddAutoMapper(typeof(RefreshProfile).Assembly);
builder.Services.AddAutoMapper(typeof(TankPumpProfile).Assembly);


// --- Services et Repositories ---
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAlertRepository, AlertRepository>();
builder.Services.AddScoped<IGenericRepository<Equipment>, GenericRepositoryImp<Equipment>>();
builder.Services.AddScoped<IGenericRepository<TankPump>, GenericRepositoryImp<TankPump>>();
builder.Services.AddScoped<IGenericRepository<Customer>, GenericRepositoryImp<Customer>>();
builder.Services.AddScoped<IRefreshService, RefreshService>();
builder.Services.AddScoped<IHistoriqueAlerteDivaRepository, HistoriqueAlerteDivaRepository>();
builder.Services.AddScoped<IHistoriqueAlertVigiRepository, HistoriqueAlertVigiRepository>();
builder.Services.AddScoped<IHistoriqueAlerteDivaService, HistoriqueAlerteDivaService>();
builder.Services.AddScoped<IHistoriqueAlertVigiService, HistoriqueAlertVigiService>();
//builder.Services.AddScoped<IServiceEquipment, ServiceEquipement>();
builder.Services.AddScoped<IGenericRepository<TankPumpVigiDto>, GenericRepositoryImp<TankPumpVigiDto>>();
builder.Services.AddScoped<IService<TankPumpVigiDto, int>, ServiceTankVigi>();
builder.Services.AddScoped<IService<TankPumpProcomDto, int>, ServiceTankProcom>();





builder.Services.AddScoped<IService<CustomerDto, int>, ServiceClient>();
builder.Services.AddScoped<IEquipementGestionService, ServiceEquipement>();
builder.Services.AddScoped<IService<TankPumpDto, int>, ServiceTank>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IRefreshRepository>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var context = provider.GetRequiredService<AirLiquideContext>();
    var mapper = provider.GetRequiredService<IMapper>();
    return new RefreshRepository(context, mapper);
});

builder.Services.AddScoped<IEquipmentRepository>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var context = provider.GetRequiredService<AirLiquideContext>();
    var mapper = provider.GetRequiredService<IMapper>();
    return new EquipmentRepository(configuration.GetConnectionString("DefaultConnection"), context, mapper);
});

//builder.Services.AddScoped<IServiceEquipment, ServiceEquipement>();

builder.Services.AddHttpContextAccessor();

// --- DbContext ---
builder.Services.AddDbContext<AirLiquideContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- SignalR ---
builder.Services.AddSignalR(options => options.EnableDetailedErrors = true);
builder.Services.AddScoped<AlertHub>();

// --- Background Services ---
builder.Services.AddSingleton<RefreshDatabaseSubscription>();
builder.Services.AddHostedService<RefreshDatabaseSubscription>();
builder.Services.AddHostedService<EquipementDatabaseSubscription>();
builder.Services.AddHttpClient();


// --- In-memory dictionary ---
builder.Services.AddSingleton<IDictionary<string, Domain.models.TankPump>>(provider => new Dictionary<string, Domain.models.TankPump>());

// --- CORS ---
builder.Services.AddCors(opts =>
    opts.AddPolicy("AllowAngular", p =>
        p.WithOrigins("http://localhost:4300")
         .AllowAnyHeader()
         .AllowAnyMethod()
         .AllowCredentials()));

// --- Configuration JWT ---
var config = builder.Configuration.GetSection("AppSettings");
var secretKey = config["Token"];
var issuer = config["Issuer"];
var audience = config["Audience"];
var keyBytes = Encoding.UTF8.GetBytes(secretKey);

builder.Services.AddAuthentication("Bearer").AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = issuer,
        ValidAudience = audience,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes)
    };
});

builder.Services.AddAuthorization();

// --- Controllers + JSON (Newtonsoft) ---
builder.Services.AddControllers();

// --- Swagger ---
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Test JWT API", Version = "v1" });

    // Ajouter l'authentification JWT dans Swagger
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Entrez 'Bearer <votre_token>' pour vous authentifier."
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

var app = builder.Build();

// --- Pipeline Middleware ---

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("AllowAngular");

app.UseAuthentication(); // IMPORTANT : auth avant autorisation
app.UseAuthorization();

// SignalR Hubs
app.MapHub<RefreshHub>("/hubs/refresh");
app.MapHub<EquipementHub>("/ClientEquipementHub");
app.MapHub<AlertHub>("/AlertHub");

// Controllers
app.MapControllers();

app.Run();
