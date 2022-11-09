
// Instatiate mail services


public class StatisticsDecorator : MailServiceDecoratorBase
{
    public StatisticsDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}");
        return base.SendMail(message);
    }
}
