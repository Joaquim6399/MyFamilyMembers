namespace MyFamilyMembers
{
    public class Person
    {
        public string Name { get; set; }
        public string Relation { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public List<Person> FamilyMembers { get; set; }

        public Person(string name, string relation)
        {
            Name = name;
            Relation = relation;
        }
    }
}
