
public class DecoratorImplementation
{
    public void Perform()
    {
        Console.Title = "Decorator";

        // Instatiate mail services
        var cloudMailService = new StatisticsDecorator(new CloudMailService());
        cloudMailService.SendMail("Hi there.");

        var onPremiseMailService = new MessageDatabaseDecorator(new OnPremiseMailService());
        onPremiseMailService.SendMail("Hi there.");
    }
}