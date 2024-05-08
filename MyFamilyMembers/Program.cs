using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "This is a API where you can see my family and friends");

//Vertex List
List<Person> people = new List<Person>();
people.Add(new Person("Joaquim") {Age = 26, Sex = "Male"});

//Adjacency Matrix
int count = people.Count;
string[,] connections = new string[count, count];

app.Run();
