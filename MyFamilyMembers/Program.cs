using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "This is a API where you can see my family and friends");

//Vertex List
List<Person> people = new List<Person>();
people.Add(new Person("Joaquim") {Age = 26, Sex = "Male"});
people.Add(new Person("Raja") {Age = 25, Sex = "Female"});

//Adjacency Matrix
int count = people.Count;
string[,] connections = new string[count, count];

void addConnection(string name1, string name2, string relationship) {
    int index1 = people.FindIndex(a => a.Name == name1);
    int index2 = people.FindIndex(a => a.Name == name2);

    if(index1 != -1 && index2 != -1) {
        connections[index1,index2] = relationship;
    } else {
        Console.WriteLine("Error! Names provided not in the list...");
    }
}

addConnection("joaquim", "raja", "wife");

app.Run();
