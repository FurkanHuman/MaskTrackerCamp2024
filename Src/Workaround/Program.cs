using Business;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;

//ServiceProvider serviceProvider = new ServiceCollection()
//    .AddBussinesServiceRegistration()
//    .BuildServiceProvider();
// ups burası fazla kaçmış... 😁😁😁😁😁

Person person1 = new() { BirthYear = 1998, FirstName = "Furkan", LastName = "Bozkurt", NId = 123 };

PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(person1);

// Konsol Çıktısı : Furkan için maske verildi


// daha önceki kaplardan olduğum için çıtır çerezlik bir ödevdi yayıla yayıola yaptım...




