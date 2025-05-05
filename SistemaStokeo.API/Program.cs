using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SistemaStokeo.API.Utilidad;
using SistemaStokeo.IOC;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.InyectarDependencias(builder.Configuration);


// Authorization JWT (agregar los roles a los controladores)
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Apistokeo", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. <br /> <br />
                      Enter 'Bearer' [space] and then your token in the text input below.<br /> <br />
                      Example: 'Bearer 12345abcdef'<br /> <br />",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });
    c.EnableAnnotations();
});

//Cors para la conection
builder.Services.AddCors(options =>
{
    options.AddPolicy("Nuevapolitica", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
}
);

var app = builder.Build();

//Prueba pusheo
// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment()) // se comento paara el dockerfile
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseCors("Nuevapolitica");

app.UseHttpsRedirection();
//jwt
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
