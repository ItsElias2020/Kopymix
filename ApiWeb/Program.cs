using ApiWeb.Midleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using UtilAutomapper;

var builder = WebApplication.CreateBuilder(args);



//CONFIGURACIÓN DEL CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "origins",
                      builder =>
                      {
                          //builder.WithOrigins("http://127.0.0.1:5500");
                          builder.AllowAnyOrigin();
                          builder.AllowAnyMethod();//get post put delete patch 
                          builder.AllowAnyHeader();//
                      });
});




// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//JWT IMPLEMENTACIÓN
builder.Services
    .AddHttpContextAccessor()
    .AddAuthorization()
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ClockSkew = TimeSpan.Zero,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });


/*CONFIGURANDO SWAGGER - PARA LA DOCUMENTACIÓN DE NUESTROS WEB SERVICES*/
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Bodeguita Yanin",
        Version = "v1",
        Description = "Documentación de los servicios para el sistema de una Bodega",
        Contact = new OpenApiContact
        {
            Name = "Jeffri Cueva",
            Email = "i2211957@continental.edu.pe",
            
        },
    }
    );
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
});


//ESTA LINEA NOS SIRVE PARA CONFIGURAR NUESTRO AUTOMAPPER
builder.Services.AddAutoMapper(typeof(IStartup).Assembly, typeof(AutoMapperProfiles).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware(typeof(ApiMiddleware));


app.MapControllers();
app.UseCors("origins");
app.Run();
