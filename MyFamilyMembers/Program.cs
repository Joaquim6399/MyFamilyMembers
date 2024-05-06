using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var familyMembers = new List<Person>
{
    new Person("Josefa", "Mum"),
    new Person("Raja", "Girlfriend")
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/joaquim", () => new Person("Joaquim", "Me") { Age = 26, Sex = "Male"});
app.MapGet("/joaquim/mum", () => familyMembers.Where(u => u.Relation == "Mum"));


app.Run();
