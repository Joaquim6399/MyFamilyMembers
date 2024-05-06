using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var myself = new Person("Joaquim", "Myself") { Age = 26, Sex = "Male" };

myself.FamilyMembers = new List<Person>();
myself.FamilyMembers.Add( new Person("Josefa", "mum"));
myself.FamilyMembers.Add( new Person("Raja", "girlfriend"));


var familyMembers = new List<Person>
{
    new Person("Josefa", "mum"),
    new Person("Raja", "Girlfriend")
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/joaquim", () => myself);
app.MapGet("/joaquim/mum", () => myself.FamilyMembers.Where(u => u.Relation == "mum"));
app.MapGet("/joaquim/girlfriend", () => myself.FamilyMembers.Where(u => u.Relation == "girlfriend"));


app.Run();
