


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
