using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{

    public void ApplyForMask(Person person)
    {
        return;
    }

    public List<Person> GetList()
    {
        return [];
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new (KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
        return client.TCKimlikNoDogrulaAsync(TCKimlikNo: person.NId,
            Ad: person.FirstName,
            Soyad: person.LastName,
            DogumYili: person.BirthYear)
            .Result.Body.TCKimlikNoDogrulaResult;
    }

}
