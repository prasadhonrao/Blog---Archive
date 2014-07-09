class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string City { get; private set; }

    public Person SetName(string name)
    {
        this.Name = name;
        return this;
    }

    public Person SetAge(int age)
    {
        this.Age = age;
        return this;
    }

    public Person SetCity(string city)
    {
        this.City = city;
        return this;
    }

    public void Save()
    {
        Console.WriteLine("Saving Person [Name: {0}, Age: {1}, City: {2}]...", this.Name, this.Age, this.City);
    }
}

new Person().SetName("Prasad Honrao")
            .SetAge(35)
            .SetCity("Pune")
            .Save();