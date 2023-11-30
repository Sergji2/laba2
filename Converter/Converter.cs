class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter()
    {
        usdRate = 36.24;
        eurRate = 39.70;
        plnRate = 9.12;
    }

    public double ConvertToUah(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount * usdRate;
            case "eur":
                return amount * eurRate;
            case "pln":
                return amount * plnRate;
            default:
                Console.WriteLine("Invalid currency code");
                return 0;
        }
    }

    public double ConvertFromUah(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount / usdRate;
            case "eur":
                return amount / eurRate;
            case "pln":
                return amount / plnRate;
            default:
                Console.WriteLine("Invalid currency code");
                return 0;
        }
    }
}