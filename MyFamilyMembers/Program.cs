using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var myself = new Person("Joaquim", "Myself") { Age = 26, Sex = "Male" };

myself.FamilyMembers.Add( new Person("Josefa", "mum"));
myself.FamilyMembers.Add( new Person("Raja", "girlfriend"));


var familyMembers = new List<Person>
{
    new Person("Josefa", "mum"),
    new Person("Raja", "Girlfriend")
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/joaquim", () => new Person("Joaquim", "Me") { Age = 26, Sex = "Male"});
app.MapGet("/joaquim/mum", () => familyMembers.Where(u => u.Relation == "Mum"));


app.Run();
