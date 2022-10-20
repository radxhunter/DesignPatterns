var builder = new PersonBuilder();

Person person = builder
                    .Lives
                        .At("Goczałkowicka 12")
                        .WithPostocode("44-251")
                        .In("Rybnik");
Console.WriteLine(person);

public class PersonBuilder
{
    //obiekt, który budujemy
    protected Person person; // to jest referencja
    public PersonBuilder() => person = new Person();

    protected PersonBuilder(Person person) => this.person = person;

    public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

    public static implicit operator Person(PersonBuilder pb)
        => pb.person;
}

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person) : base(person)
    {
        this.person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        person.StreetAddress = streetAddress;
        return this;
    }

    public PersonAddressBuilder WithPostocode(string postcode)
    {
        person.Postcode = postcode;
        return this;
    }

    public PersonAddressBuilder In(string city)
    {
        person.City = city;
        return this;
    }
}

public class Person
{
    public string StreetAddress { get; set; }
    public string Postcode { get; set; }
    public string City { get; set; }

    public string? CompanyName { get; set; }
    public string? Poistion { get; set; }

    public int AnnualIncome { get; set; }

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, " +
            $"{nameof(Postcode)}: {Postcode}, " +
            $"{nameof(City)}: {City}, ";
    }
}
