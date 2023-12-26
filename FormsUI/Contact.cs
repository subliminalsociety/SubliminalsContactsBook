using System;

namespace FormsUI
{
    public class Contact
    {
        private static readonly Random random = new Random();

        public Contact(
            string name,
            string phoneNumber,
            string emailAddress,
            string address,
            string jobTitle,
            string company,
            string birthday,
            string notes)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            Address = address;
            JobTitle = jobTitle;
            Company = company;
            Birthday = birthday;
            Notes = notes;
        }

        public string Name { get; }
        public string PhoneNumber { get; }
        public string EmailAddress { get; }
        public string Address { get; }
        public string JobTitle { get; }
        public string Company { get; }
        public string Birthday { get; }
        public string Notes { get; }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Phone Number: {PhoneNumber}\n" +
                   $"Email Address: {EmailAddress}\n" +
                   $"Address Top: {Address}\n" +
                   $"Job Title: {JobTitle}\n" +
                   $"Company: {Company}\n" +
                   $"Birthday: {Birthday}\n" +
                   $"Notes: {Notes}";
        }

        public static Contact GenerateRandomContact()
        {
            var random = new Random();

            // Generate random values for each property
            var randomName = GenerateRandomName();
            var randomPhoneNumber = GenerateRandomPhoneNumber();
            var randomEmailAddress = $"{randomName.Replace(" ", "").ToLower()}@example.com";
            var randomAddress = GenerateRandomAddress();
            var randomJobTitle = GenerateRandomJobTitle();
            var randomCompany = GenerateRandomCompany();
            var randomBirthday = GenerateRandomBirthday();
            var randomNotes = "EMPTY";

            // Create and return a new Contact object with random values
            return new Contact(
                randomName,
                randomPhoneNumber,
                randomEmailAddress,
                randomAddress,
                randomJobTitle,
                randomCompany,
                randomBirthday,
                randomNotes);
        }

        private static string GenerateRandomName()
        {
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Emma", "Christopher", "Olivia" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };

            var firstName = firstNames[random.Next(firstNames.Length)];
            var lastName = lastNames[random.Next(lastNames.Length)];

            return $"{firstName} {lastName}";
        }

        private static string GenerateRandomPhoneNumber()
        {
            // Simplified logic for generating a random phone number
            return $"+1 {random.Next(100, 999)}-{random.Next(1000, 9999)}";
        }

        private static string GenerateRandomAddress()
        {
            // Simplified logic for generating a random address
            return
                $"{random.Next(1, 999)} {GenerateRandomStreet()} St, {GenerateRandomCity()}, {GenerateRandomCountry()}";
        }

        private static string GenerateRandomStreet()
        {
            string[] streetNames = { "Main", "Maple", "Oak", "Pine", "Cedar", "Elm", "Spruce", "Birch" };
            return streetNames[random.Next(streetNames.Length)];
        }

        private static string GenerateRandomCity()
        {
            string[] cities =
                { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "Dallas" };
            return cities[random.Next(cities.Length)];
        }

        private static string GenerateRandomCountry()
        {
            string[] countries = { "USA", "Canada", "UK", "Australia", "Germany", "France", "Japan", "Brazil" };
            return countries[random.Next(countries.Length)];
        }

        private static string GenerateRandomJobTitle()
        {
            string[] jobTitles =
            {
                "Software Developer", "Data Scientist", "Marketing Specialist", "Financial Analyst", "HR Manager",
                "Graphic Designer", "Product Manager", "Sales Representative"
            };
            return jobTitles[random.Next(jobTitles.Length)];
        }

        private static string GenerateRandomCompany()
        {
            string[] companies =
            {
                "TechCo", "Innovate Solutions", "Global Enterprises", "Data Dynamics", "Creative Minds",
                "Market Trends", "EcoTech", "Alpha Innovations"
            };
            return companies[random.Next(companies.Length)];
        }

        private static string GenerateRandomBirthday()
        {
            // Simplified logic for generating a random birthday
            var year = random.Next(1970, 2000);
            var month = random.Next(1, 13);
            var day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return $"{month}/{day}/{year}";
        }
    }
}