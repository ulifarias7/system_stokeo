using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using SistemaStokeo.API.Swagger.Examples;
using SistemaStokeo.API.Swagger.Fillters;
using SistemaStokeo.IOC;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;


//crea un host web que incluye tanto inyeccion de dpependecia ,configuracion desde el appsetting etc
var builder = WebApplication.CreateBuilder(args);


//servicios basicos
builder.Services.AddControllers();

//permite a swagger explortar los enpoints 
builder.Services.AddEndpointsApiExplorer();// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//prepara al swager para generar la documentacion de los end-points
builder.Services.AddSwaggerGen();

//inyeccion de dependencia personalizada
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
    // Configuración de Swagger "documentacion"
    c.OperationFilter<ApiResponseExamplesFilter>(); // Para ejemplos de respuestas
    c.ExampleFilters();  // Habilita el sistema de ejemplos


});
//otros assemblies si están en diferentes proyectos(declaracion de las clases de ejemplos )
builder.Services.AddSwaggerExamplesFromAssemblies(
    typeof(SuccessExample).Assembly,
    typeof(NotFoundExample).Assembly,
    typeof(InternalErrorExample).Assembly,
    typeof(ForbiddenExample).Assembly
);



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

//lo comentado quiere decir que el swagger va a estar publico pero si se descomenta solo en desearrollo se va a poder usar 
// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment()) // se comento paara el dockerfile
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseCors("Nuevapolitica");

//middleware de https y jwt
app.UseHttpsRedirection();
//jwt
app.UseAuthentication();

app.UseAuthorization();

//Esto permite que las rutas [HttpGet], [HttpPost], etc., funcionen. Es obligatorio en Web API.
app.MapControllers();


//Lanza el servidor Kestrel y deja el hilo principal corriendo.
app.Run();
