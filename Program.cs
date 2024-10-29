using System.Text;
using SistemaHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<User> guests = new List<User>();

User user1 = new User("Hóspede 1");
User user2 = new User("Hóspede 2");

guests.Add(user1);
guests.Add(user2);

Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyValue: 30);

Reserve reserve = new Reserve(reservedDays: 10);
reserve.RegisterSuite(suite);
reserve.RegisterGuests(guests);

Console.WriteLine($"Hóspedes: {reserve.GetQuantityGuests()}");
Console.WriteLine($"Valor diária: {reserve.CalculateDailyValue()}");
