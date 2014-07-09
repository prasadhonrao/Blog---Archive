class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string City { get; private set; }

    public void SetName(string name)
    {
        this.Name = name;
    }

    public void SetAge(int age)
    {
        this.Age = age;
    }

    public void SetCity(string city)
    {
        this.City = city;
    }

    public void Save()
    {
    	Console.WriteLine("Saving Person [Name: {0}, Age: {1}, City: {2}]...", this.Name, this.Age, this.City);
    }
}

var newPerson = new Person();
newPerson.SetName("Bill");
newPerson.SetAge(60);
newPerson.SetCity("NY");
newPerson.Save();

