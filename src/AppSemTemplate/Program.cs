using AppSemTemplate.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.AddMvcConfiguration()
       .AddIdentityConfiguration()
       .AddDependencyInjectionConfiguration();


//builder.Services.AddRouting(options => options.ConstraintMap["slugfy"] = typeof(RouteSlugifyParameterTransformer));

var app = builder.Build();

app.UseMvcConfiguration();

app.Run();
