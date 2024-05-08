using Microsoft.VisualBasic;
using MyFamilyMembers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



//Vertex List
List<Person> people = new List<Person>();
people.Add(new Person("Joaquim") {Age = 26, Sex = "Male"});
people.Add(new Person("Raja") {Age = 25, Sex = "Female"});
people.Add(new Person("Josefa") {Age = 55, Sex = "Female"});

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
addConnection("joaquim", "josefa", "mum");
addConnection("Raja", "joaquim", "husband");

List<Person> findAllConnection(string name) {
    List<Person> result = new List<Person>();

    //Find index of named user to search in matrix
    int index = people.FindIndex(a => a.Name == name);

    /*
        Loop through one matrix line to search for non null values,
        which mean theres a connection
    */
    for(int i = 0; i < count; i++) {
        if(connections[index, i] != null) {
            result.Add(people[i]);
        }
    }
    return result;
}

app.MapGet("/", () => "This is a API where you can see my family and friends");
app.MapGet("/joaquim", () => findAllConnection("joaquim"));
app.Run();
