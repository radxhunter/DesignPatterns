public class BuilderImplementation
{
    public static void Perform()
    {
        var builder = new PersonBuilder();

        Person person = builder
                            .Lives
                                .At("Goczałkowicka 12")
                                .WithPostocode("44-251")
                                .In("Rybnik");
        Console.WriteLine(person);
    }
}