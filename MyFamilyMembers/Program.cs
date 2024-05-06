using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/me", () => new Person { Name = "Joaquim", Age = 26, Relation = "Me", Sex = "Male"});


app.Run();
