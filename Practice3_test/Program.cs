List<string> CountryListA = new List<string>
        {
            "Afghanistan", "Albania", "Algeria", "Andorra", "Angola",
            "Cabo Verde", "Namibia", "Nauru", "Nepal", "Netherlands",
            "New Zealand", "Nicaragua",
        };

List<string> CountryListB = new List<string>
        {
            "Afghanistan", "Albania", "Algeria", "Andorra", "Angola",
            "Ukraine", "United Arab Emirates", "United Kingdom", "United States",
            "Uruguay", "Uzbekistan"
        };
var countriesOnlyInA = CountryListA.Except(CountryListB).ToList();

Console.WriteLine("Countries only in List A:");
foreach (var country in countriesOnlyInA)
{
    Console.WriteLine(country);
}