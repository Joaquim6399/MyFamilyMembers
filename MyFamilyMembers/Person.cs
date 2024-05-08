namespace MyFamilyMembers
{
    public class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Person(string name)
        {
            Name = name.ToLower();
        }
    }
}
