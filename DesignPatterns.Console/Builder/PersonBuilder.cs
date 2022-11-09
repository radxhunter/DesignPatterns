
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
